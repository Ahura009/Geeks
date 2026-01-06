using University.Domain.SeminarGroups.Aggregate;
using University.Infra;
using University.Infra.Core.Enum;

namespace University.Application.Students.Service;

public sealed class AllocateSeminarGroupAutomaticallyAppService
{
    public Dictionary<Guid, (Dictionary<Guid, List<Guid>> Allocations, List<Guid> Unassigned)> AllocateAll()
    {
        var allModuleIds = DbContext.Modules.Select(m => m.Id).ToList();
        var result = new Dictionary<Guid, (Dictionary<Guid, List<Guid>> Allocations, List<Guid> Unassigned)>();

        foreach (var moduleId in allModuleIds) result[moduleId] = AllocateForModule(moduleId);

        return result;
    }

    private (Dictionary<Guid, List<Guid>> Allocations, List<Guid> Unassigned) AllocateForModule(Guid moduleId)
    {
        //  بارگذاری دانشجوهای ثبت‌نام‌شده در این ماژول
        var students = DbContext.Students
            .Where(s => s.StudentModule.Any(sm => sm.ModuleId == moduleId))
            .ToList();

        //  بارگذاری گروه‌های سمینار این ماژول
        var seminarGroups = DbContext.SeminarGroups
            .Where(sg => sg.ModuleId == moduleId)
            .ToList();

        // اگر گروهی وجود ندارد  ثبت NoSeminarGroups
        if (!seminarGroups.Any())
        {
            foreach (var student in students) student.AddConflictToStudent(Guid.Empty, ConflictType.NoSeminarGroups);
            return (new Dictionary<Guid, List<Guid>>(), students.Select(s => s.Id).ToList());
        }

        // بارگذاری تمام گروه‌های فعلی دانشجو برای بررسی clash
        var studentTimetables = students.ToDictionary(
            s => s.Id,
            s => s.StudentSeminarGroup
                .Select(ssg => DbContext.SeminarGroups.FirstOrDefault(g => g.Id == ssg.SeminarGroupId))
                .Where(g => g != null)
                .ToList()
        );

        //  آماده‌سازی خروجی
        var allocations = new Dictionary<Guid, List<Guid>>();
        var unassigned = new List<Guid>();
        var remainingCapacity = seminarGroups.ToDictionary(g => g.Id, g => (int)g.Capacity);

        //  پردازش هر دانشجو به ترتیب عادلانه
        var sortedStudent = students.OrderBy(s => s.Priority);
        foreach (var student in sortedStudent)
        {
            SeminarGroup? chosenGroup = null;

            foreach (var group in seminarGroups)
            {
                // آیا دانشجو قبلاً در همین گروه ثبت شده؟   DuplicateRegistration
                if (student.StudentSeminarGroup.Any(ssg => ssg.SeminarGroupId == group.Id))
                {
                    student.AddConflictToStudent(group.Id, ConflictType.DuplicateRegistration);
                    continue;
                }

                //  آیا ظرفیت گروه پر است؟ 
                if (remainingCapacity[group.Id] <= 0)
                {
                    student.AddConflictToStudent(group.Id, ConflictType.CapacityFull);
                    continue;
                }


                var currentSlots = studentTimetables[student.Id];
                if (currentSlots.Any(existing => group.OverlapsWith(existing)))
                {
                    student.AddConflictToStudent(group.Id, ConflictType.TimeOverlap);
                    continue;
                }


                chosenGroup = group;
                break;
            }

            if (chosenGroup == null)
            {
                unassigned.Add(student.Id);
            }
            else
            {
                student.AddSeminarGroupToStudent(chosenGroup.Id);
                allocations.TryAdd(chosenGroup.Id, new List<Guid>());
                allocations[chosenGroup.Id].Add(student.Id);
                remainingCapacity[chosenGroup.Id]--;
            }
        }

        return (allocations, unassigned);
    }
}
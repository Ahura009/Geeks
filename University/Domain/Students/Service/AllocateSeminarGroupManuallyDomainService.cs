using University.Domain.SeminarGroups.Aggregate;
using University.Domain.Students.Aggregate;
using University.Infra.Core.Enum;
using University.Infra.Core.Exceptions;

namespace University.Domain.Students.Service;

internal sealed class AllocateSeminarGroupManuallyDomainService
{
    public bool ValidateRegistration(Student student, SeminarGroup targetSeminarGroup,
        IReadOnlyCollection<SeminarGroup> registeredSeminarGroups, int currentRegisterCount, int moduleCapacity,
        out ConflictType? conflictType)
    {
        conflictType = null;

        // تکراری بودن
        if (student.StudentSeminarGroup.Any(ssg => ssg.SeminarGroupId == targetSeminarGroup.Id))
        {
            conflictType = ConflictType.DuplicateRegistration;
            return false;
        }

        // ظرفیت گروه
        if (currentRegisterCount >= targetSeminarGroup.Capacity)
            throw new DomainConflictException(ConflictType.CapacityFull, "ظرفیت این گروه سمینار تکمیل شده است.");

        // تداخل زمانی
        var overlap = registeredSeminarGroups.FirstOrDefault(existing => existing.OverlapsWith(targetSeminarGroup));
        if (overlap != null)
        {
            var msg =
                $"تداخل زمانی با کلاس {overlap.StartTime.ToString("hh\\:mm")} - {overlap.EndTime.ToString("hh\\:mm")}";
            throw new DomainConflictException(ConflictType.TimeOverlap, msg);
        }

        return true;
    }
}
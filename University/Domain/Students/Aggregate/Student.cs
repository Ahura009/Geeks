using University.Domain.Students.Entity;
using University.Infra.Core.Enum;
using University.Infra.Domain;

namespace University.Domain.Students.Aggregate;

internal sealed class Student : AggregateRoot<Guid>
{
    private readonly List<StudentConflict> _studentConflict = [];
    private readonly List<StudentGrade> _studentGrades = [];
    private readonly List<StudentModule> _studentModule = [];
    private readonly List<StudentSeminarGroup> _studentSeminarGroup = [];


    private Student()
    {
    }

    public string FullName { get; private set; } = null!;
    public long Priority { get; private set; }

    public IReadOnlyCollection<StudentGrade> StudentGrades => _studentGrades;
    public IReadOnlyCollection<StudentSeminarGroup> StudentSeminarGroup => _studentSeminarGroup;
    public IReadOnlyCollection<StudentConflict> StudentConflict => _studentConflict;
    public IReadOnlyCollection<StudentModule> StudentModule => _studentModule;


    public static Student Create(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("نام دانشجو نمی‌تواند خالی باشد.", nameof(fullName));

        fullName = fullName.Trim();

        if (fullName.Length is < 3 or > 100)
            throw new ArgumentException("نام دانشجو باید بین ۳ تا ۱۰۰ کاراکتر باشد.", nameof(fullName));

        return new Student
        {
            FullName = fullName,
            Id = Guid.NewGuid(),
            Priority = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
        };
    }

    public void AddGradeToStudent(Guid moduleId, decimal weight, DateTimeOffset dateUtc, int grade)
    {
        if (moduleId == Guid.Empty)
            throw new ArgumentException("Invalid moduleId");

        if (grade < 0 || grade > 100)
            throw new ArgumentException("Score must be 0-100");

        if (weight <= 0 || weight > 1)
            throw new ArgumentException("Weight must be between 0 and 1");

        var existing = _studentGrades.Any(g => g.ModuleId == moduleId);
        if (existing)
            throw new InvalidOperationException("StudentGrade already exists. Use ApplyResit.");

        _studentGrades.Add(new StudentGrade(Id, moduleId, weight, dateUtc, grade));
    }

    public void AddSeminarGroupToStudent(Guid seminarGroupId)
    {
        if (seminarGroupId == Guid.Empty)
            throw new ArgumentException("Invalid seminarGroupId");

        if (_studentSeminarGroup.Any(sc => sc.SeminarGroupId == seminarGroupId))
            throw new InvalidOperationException("Student already register in this class");

        _studentSeminarGroup.Add(new StudentSeminarGroup(Id, seminarGroupId));
    }

    public void AddConflictToStudent(Guid seminarGroupId, ConflictType conflictType)
    {
        if (seminarGroupId == Guid.Empty)
            throw new ArgumentException("Invalid seminarGroupId");

        _studentConflict.Add(new StudentConflict(Id, seminarGroupId, conflictType));
    }

    public void AddModulesToStudent(List<Guid> moduleIds)
    {
        foreach (var moduleId in moduleIds)
        {
            if (moduleId == Guid.Empty)
                throw new ArgumentException("Invalid seminarGroupId");

            if (_studentModule.Any(x => x.ModuleId == moduleId))
                continue;

            _studentModule.Add(new StudentModule(Id, moduleId));
        }
    }
}
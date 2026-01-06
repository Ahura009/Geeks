using University.Infra;

namespace University.Application.Students.Command.AddResitGradeToStudent;

public class AddResitGradeToStudentCommandHandler
{
    public void Handle(AddResitGradeToStudentCommand command)
    {
        if (command.StudentId == Guid.Empty)
            throw new ArgumentException("StudentId is required");

        if (command.ModuleId == Guid.Empty)
            throw new ArgumentException("ModuleId is required");

        if (command.ResitScore < 0 || command.ResitScore > 100)
            throw new ArgumentException("ResitScore must be between 0 and 100");

        // پیدا کردن دانشجو
        var student = DbContext.Students
            .FirstOrDefault(s => s.Id == command.StudentId);

        if (student == null)
            throw new InvalidOperationException("Student not found");

        // پیدا کردن نمره اصلی ماژول
        var grade = student.StudentGrades
            .FirstOrDefault(g => g.ModuleId == command.ModuleId);

        if (grade == null)
            throw new InvalidOperationException("No existing grade found for this module. Cannot add resit.");

        // اضافه کردن نمره رسیت
        grade.AddResitGrade(command.ResitScore, command.ResitDateUtc);
    }
}
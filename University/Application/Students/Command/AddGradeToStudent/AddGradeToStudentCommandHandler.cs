using University.Infra;

namespace University.Application.Students.Command.AddGradeToStudent;

public class AddGradeToStudentCommandHandler
{
    public void Handle(AddGradeToStudentCommand command)
    {
        if (command.StudentId == Guid.Empty)
            throw new ArgumentException("StudentId is required");

        if (command.ModuleId == Guid.Empty)
            throw new ArgumentException("ModuleId is required");

        if (command.Score < 0 || command.Score > 100)
            throw new ArgumentException("Score must be between 0 and 100");

        if (command.Weight < 0m || command.Weight > 1m)
            throw new ArgumentException("Weight must be between 0 and 1");

        // پیدا کردن دانشجو
        var student = DbContext.Students
            .FirstOrDefault(s => s.Id == command.StudentId);

        if (student == null)
            throw new InvalidOperationException("Student not found");

        var existingModule = student.StudentModule.Any(x => x.ModuleId == command.ModuleId);
        if (!existingModule)
            throw new InvalidOperationException("دانل اموز ماژول زیر را ندارد");

        // بررسی اینکه نمره برای این ماژول قبلا ثبت نشده
        var existingGrade = student.StudentGrades
            .FirstOrDefault(g => g.ModuleId == command.ModuleId);

        if (existingGrade != null)
            throw new InvalidOperationException("Grade already exists. Use resit.");

        // اضافه کردن نمره جدید
        student.AddGradeToStudent(
            command.ModuleId,
            command.Weight,
            command.DateUtc,
            command.Score
        );
    }
}
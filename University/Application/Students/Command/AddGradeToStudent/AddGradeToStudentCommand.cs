namespace University.Application.Students.Command.AddGradeToStudent;

public class AddGradeToStudentCommand
{
    public Guid StudentId { get; set; }
    public Guid ModuleId { get; set; }
    public decimal Weight { get; set; }
    public DateTimeOffset DateUtc { get; set; }
    public int Score { get; set; }
}
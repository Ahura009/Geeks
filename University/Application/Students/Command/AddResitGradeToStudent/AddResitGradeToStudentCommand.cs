namespace University.Application.Students.Command.AddResitGradeToStudent;

public class AddResitGradeToStudentCommand
{
    public Guid StudentId { get; set; }
    public Guid ModuleId { get; set; }
    public decimal Weight { get; set; }
    public DateTimeOffset ResitDateUtc { get; set; }
    public int ResitScore { get; set; }
}
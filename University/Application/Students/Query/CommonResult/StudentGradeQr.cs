namespace University.Application.Students.Query.CommonResult;

public class StudentGradeQr
{
    public Guid GradeId { get; set; }
    public Guid StudentId { get; set; }
    public Guid ModuleId { get; set; }
    public int Score { get; set; }
    public int? ResitScore { get; set; }
    public decimal Weight { get; set; }
    public DateTimeOffset DateUtc { get; set; }
    public DateTimeOffset? ResitDateUtc { get; set; }
    public int FinalScore { get; set; }
}
using University.Infra.Domain;

namespace University.Domain.Students.Entity;

internal sealed class StudentGrade : Entity<Guid>
{
    internal StudentGrade(Guid studentId, Guid moduleId, decimal weight, DateTimeOffset dateUtc, int score)
    {
        if (studentId == Guid.Empty)
            throw new ArgumentException(nameof(studentId));

        if (moduleId == Guid.Empty)
            throw new ArgumentException(nameof(moduleId));

        if (weight <= 0 || weight > 1)
            throw new ArgumentException("Weight must be between 0 and 1");

        if (score < 0 || score > 100)
            throw new ArgumentException("Score must be 0-100");

        StudentId = studentId;
        ModuleId = moduleId;
        Weight = weight;
        DateUtc = dateUtc;
        Score = score;
        Id = Guid.NewGuid();
    }

    public Guid StudentId { get; private set; }
    public Guid ModuleId { get; private set; }
    public decimal Weight { get; private set; }
    public DateTimeOffset DateUtc { get; private set; }
    public DateTimeOffset? ResitDateUtc { get; private set; }
    public int Score { get; }
    public int? ResitScore { get; private set; }

    public int FinalScore =>
        ResitScore.HasValue && ResitScore > Score
            ? ResitScore.Value
            : Score;

    public void AddResitGrade(int resitScore, DateTimeOffset? resitDateUtc = null)
    {
        if (ResitScore.HasValue)
            throw new InvalidOperationException("Resit already exists");

        if (resitScore < 0 || resitScore > 100)
            throw new ArgumentException("Score must be 0-100");

        ResitScore = resitScore;
        ResitDateUtc = resitDateUtc ?? DateTimeOffset.UtcNow;
    }
}
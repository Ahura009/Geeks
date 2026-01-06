using University.Application.Students.Query.CommonResult;
using University.Application.Students.Query.StudentGrade;

namespace University.Infra.Query.StudentGrade;

public sealed class StudentGradeQueryService
{
    public List<StudentGradeQr> Execute(GetGradeByStudentQuery query)
    {
        return DbContext.Students
            .Where(s => s.Id == query.StudentId)
            .SelectMany(s => s.StudentGrades)
            .Select(g => new StudentGradeQr
            {
                GradeId = g.Id,
                StudentId = g.StudentId,
                ModuleId = g.ModuleId,
                Score = g.Score,
                ResitScore = g.ResitScore,
                Weight = g.Weight,
                DateUtc = g.DateUtc,
                ResitDateUtc = g.ResitDateUtc,
                FinalScore = g.ResitScore.HasValue && g.ResitScore > g.Score ? g.ResitScore.Value : g.Score
            }).ToList();
    }
}
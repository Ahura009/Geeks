using University.Application.Students.Query.CommonResult;
using University.Infra.Application;
using University.Infra.Query.StudentGrade;

namespace University.Application.Students.Query.StudentGrade;

public class GetGradeByStudentQueryHandler
{
    public ApplicationServiceResult<List<StudentGradeQr>> Handle(GetGradeByStudentQuery query)
    {
        var modules = new StudentGradeQueryService().Execute(query);
        return new ApplicationServiceResult<List<StudentGradeQr>>
            { Data = modules, State = ApplicationServiceState.Ok };
    }
}
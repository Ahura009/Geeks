using University.Application.Students.Service;
using University.Infra.Application;

namespace University.Application.Students.Command.AllocateSeminarGroupManually;

public sealed class AllocateSeminarGroupManuallyCommandHandler
{
    public ApplicationServiceResult Handle(AllocateSeminarGroupManuallyCommand command)
    {
        new AllocateSeminarGroupManuallyAppService().Register(command.StudentId, command.ModuleIds);

        return new ApplicationServiceResult
        {
            State = ApplicationServiceState.Ok,
            Message = "درس(ها) با موفقیت به دانشجو اختصاص یافت."
        };
    }
}
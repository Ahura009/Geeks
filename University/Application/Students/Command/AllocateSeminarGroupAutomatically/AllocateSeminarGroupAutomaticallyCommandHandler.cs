using University.Application.Students.Service;

namespace University.Application.Students.Command.AllocateSeminarGroupAutomatically;

public sealed class AllocateSeminarGroupAutomaticallyCommandHandler
{
    public void Handle()
    {
        var data = new AllocateSeminarGroupAutomaticallyAppService().AllocateAll();
    }
}
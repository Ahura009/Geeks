namespace University.Application.Students.Command.AllocateSeminarGroupManually;

public sealed class AllocateSeminarGroupManuallyCommand
{
    public required Guid StudentId { get; set; }
    public required List<Guid> ModuleIds { get; set; }
}
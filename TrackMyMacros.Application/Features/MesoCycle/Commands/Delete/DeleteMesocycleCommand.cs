namespace TrackMyMacros.Application.Features.Mesocycle.Commands.Delete
{
    public class DeleteMesocycleCommand : RequestBase<Result>
    {
        public Guid Id { get; set; }
    }
}
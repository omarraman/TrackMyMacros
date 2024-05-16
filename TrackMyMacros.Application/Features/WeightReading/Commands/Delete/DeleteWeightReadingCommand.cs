namespace TrackMyMacros.Application.Features.WeightReading.Commands.Delete
{
    public class DeleteWeightReadingCommand : RequestBase<Result>
    {
        public Guid Id { get; set; }
    }
}
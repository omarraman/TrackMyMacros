namespace TrackMyMacros.Application.Features.WeightReading.Commands.Create
{
    public class CreateWeightReadingCommand : RequestBase<Result<Guid>>
    {
        public DateTime Date { get; set; }
        public double Weight { get; set; }
    }
}
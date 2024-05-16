namespace TrackMyMacros.Application.Features.WeightReading.Commands.Update
{
    public class UpdateWeightReadingCommand : RequestBase<Result>
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double Weight { get; set; }
    }
}
namespace TrackMyMacros.Dtos.WeightReading
{
    public class UpdateWeightReadingDto
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double Weight { get; set; }
    }
}
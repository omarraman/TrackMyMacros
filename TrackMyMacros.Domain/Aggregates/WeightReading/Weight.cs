using TrackMyMacros.Attributes;

namespace TrackMyMacros.Domain.Aggregates.WeightReading;

[CodeGen]
public class WeightReading
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public double Weight { get; set; }
}
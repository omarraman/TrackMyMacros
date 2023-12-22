using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.DailyLimit;

public class DailyLimits:Entity
{
    public Guid Id { get; set; }
    public int Calories { get; set; }
    public int Protein { get; set; }
    public int Fat { get; set; }
    public int Carbohydrate { get; set; }
}
using Ardalis.GuardClauses;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.DailyLimit;

public class DailyLimits:Entity
{
    public Guid Id { get; set; }
    public int Calories { get; set; }

    public double WeightInKg { get; set; }

    public DailyLimits(int calories, double weightInKg)
    {
        WeightInKg = Guard.Against.NegativeOrZero(weightInKg, nameof(weightInKg)); 
        Calories=Guard.Against.NegativeOrZero(calories, nameof(calories));
    }
    
    private DailyLimits()
    {
        
    }
}
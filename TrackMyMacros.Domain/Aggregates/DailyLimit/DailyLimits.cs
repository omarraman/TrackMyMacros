using Ardalis.GuardClauses;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.DailyLimit;

public class DailyLimits:Entity
{
    public Guid Id { get; set; }
    public int Calories { get; set; }

    public double WeightInKg { get; set; }

    public int WeekdaysMealsPerDay { get; set; }
    public int WeekendMealsPerDay { get; set; }

    public DailyLimits(int calories, double weightInKg, int weekdaysMealsPerDay,int weekendMealsPerDay)
    {
        Calories = Guard.Against.NegativeOrZero(calories, nameof(calories));
        WeightInKg = Guard.Against.NegativeOrZero(weightInKg, nameof(weightInKg));
        WeekdaysMealsPerDay = Guard.Against.NegativeOrZero(weekdaysMealsPerDay, nameof(weekdaysMealsPerDay));
        WeekendMealsPerDay = Guard.Against.NegativeOrZero(weekendMealsPerDay, nameof(weekendMealsPerDay));
    }

    
    private DailyLimits()
    {
        
    }
}
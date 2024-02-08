
namespace TrackMyMacros.Application.Features.DailyLimits.Commands.UpdateDailyLimits;

public class UpdateDailyLimitsCommand:RequestBase<Result>
{
    public int Calories { get; set; }
    public double WeightInKg { get; set; }
    public int WeekdaysMealsPerDay { get; set; }
    public int WeekendMealsPerDay { get; set; }
}
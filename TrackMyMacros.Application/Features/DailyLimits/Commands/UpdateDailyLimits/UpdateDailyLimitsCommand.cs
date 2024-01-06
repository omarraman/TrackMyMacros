
namespace TrackMyMacros.Application.Features.DailyLimits.Commands.UpdateDailyLimits;

public class UpdateDailyLimitsCommand:RequestBase<Result>
{
    public int Calories { get; set; }
    public double WeightInKg { get; set; }
}
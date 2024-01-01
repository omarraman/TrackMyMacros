
namespace TrackMyMacros.Application.Features.DailyLimits.Commands.UpdateDailyLimits;

public class UpdateDailyLimitsCommand:RequestBase<Result>
{
    public int Carbohydrate { get; set; }
    public int Protein { get; set; }
    public int Fat { get; set; }
    public int Calories { get; set; }

}
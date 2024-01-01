using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Services.DailyLimitsDataService;

public class BadArgumentErrorResult : ErrorResult<DailyLimitsViewModel>
{
    public BadArgumentErrorResult(string message) : base(message)
    {
    }


}
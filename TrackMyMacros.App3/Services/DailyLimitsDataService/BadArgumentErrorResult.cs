using TrackMyMacros.App3.ViewModels;

namespace TrackMyMacros.App3.Services.DailyLimitsDataService;

public class BadArgumentErrorResult : ErrorResult<DailyLimitsViewModel>
{
    public BadArgumentErrorResult(string message) : base(message)
    {
    }


}
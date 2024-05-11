using TrackMyMacros.App4.ViewModels;

namespace TrackMyMacros.App4.Services.DailyLimitsDataService
{
    public class BadArgumentErrorResult : ErrorResult<DailyLimitsViewModel>
    {
        public BadArgumentErrorResult(string message) : base(message)
        {
        }


    }
}
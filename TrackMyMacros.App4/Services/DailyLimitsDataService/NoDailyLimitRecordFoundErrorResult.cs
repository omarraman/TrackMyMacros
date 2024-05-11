using TrackMyMacros.App4.ViewModels;

namespace TrackMyMacros.App4.Services.DailyLimitsDataService
{
    public class NoDailyLimitRecordFoundErrorResult : ErrorResult<DailyLimitsViewModel>
    {
        public NoDailyLimitRecordFoundErrorResult(string message) : base(message)
        {
        }

        public NoDailyLimitRecordFoundErrorResult(string message, IReadOnlyCollection<Error> errors) : base(message, errors)
        {
        }
    }
}
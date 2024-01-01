using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Services.DailyLimitsDataService;

public class NoDailyLimitRecordFoundErrorResult : ErrorResult<DailyLimitsViewModel>
{
    public NoDailyLimitRecordFoundErrorResult(string message) : base(message)
    {
    }

    public NoDailyLimitRecordFoundErrorResult(string message, IReadOnlyCollection<Error> errors) : base(message, errors)
    {
    }
}
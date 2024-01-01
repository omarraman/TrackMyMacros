namespace TrackMyMacros.Application.Features.DailyLimits.Commands.UpdateDailyLimits;

public class UpdateDailyLimitsInvalidArgumentsResult : ErrorResult
{
    public UpdateDailyLimitsInvalidArgumentsResult(string message) : base(message)
    {
    }
}
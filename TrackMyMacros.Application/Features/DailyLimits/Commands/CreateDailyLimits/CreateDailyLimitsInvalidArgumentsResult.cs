namespace TrackMyMacros.Application.Features.DailyLimits.Commands.CreateDailyLimits;

public class CreateDailyLimitsInvalidArgumentsResult : ErrorResult<Guid>
{
    public CreateDailyLimitsInvalidArgumentsResult(string message) : base(message)
    {
    }
}
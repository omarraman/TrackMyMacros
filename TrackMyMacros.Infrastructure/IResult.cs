using TrackMyMacros.Infrastructure;

public interface IResult
{
    bool IsSuccess { get; }
    FailureReason FailureReason { get; set; }
    bool IsRetriable { get; set; }
    bool IsFailure { get; }
}
using TrackMyMacros.Infrastructure.Interfaces;

public class ErrorResult : Result, IErrorResult
{
    public ErrorResult(string message) : this(message, Array.Empty<Error>())
    {
    }

    public ErrorResult(string message, IReadOnlyCollection<Error> errors)
    {
        Message = message;
        IsSuccess = false;
        Errors = errors ?? Array.Empty<Error>();
    }

    public string Message { get; }
    public IReadOnlyCollection<Error> Errors { get; }
    
    public string GetErrorString()
    {
        return Message + " " + string.Join(", ", Errors.Select(e => e.Code + ": " + e.Details));
    }
}



public class ErrorResult<T> : Result<T>, IErrorResult
{
    public ErrorResult(string message) : this(message, Array.Empty<Error>())
    {    
    }

    public ErrorResult(string message, IReadOnlyCollection<Error> errors) : base(default)
    {
        Message = message;
        IsSuccess = false;
        Errors = errors ?? Array.Empty<Error>();
    }

    public string Message { get; set; }
    public IReadOnlyCollection<Error> Errors { get; }
    
    public string GetErrorString()
    {
        return Message + " " + string.Join(", ", Errors.Select(e => e.Code + ": " + e.Details));
    }
}



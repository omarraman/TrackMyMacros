using System;
using System.Diagnostics.CodeAnalysis;
using TrackMyMacros.Infrastructure;


public class Result : IResult
{
    public bool IsSuccess { get; }

    public FailureReason FailureReason { get; set; } = FailureReason.UnhandledError();
    
    public  bool IsRetriable { get; set; }
    
    public bool IsFailure => !IsSuccess;

    protected Result(bool isSuccess, FailureReason error)
    {
        if (isSuccess && error != null)
            throw new InvalidOperationException();
        if (!isSuccess && error == null)
            throw new InvalidOperationException();

        IsSuccess = isSuccess;
        FailureReason = error;
    }

    public static Result Fail(FailureReason error)
    {
        return new Result(false, error);
    }
    
    public static Result<T> Fail<T>(FailureReason error)
    {
        return new Result<T>(default(T), false, error);
    }

    public static Result Ok()
    {
        return new Result(true, null);
    }

    public static Result<T> Ok<T>(T value)
    {
        return new Result<T>(value, true, null);
    }

    public static Result Combine(params Result[] results)
    {
        foreach (Result result in results)
        {
            if (result.IsFailure)
                return result;
        }

        return Ok();
    }
    
}


public class Result<T> : Result
{
    private readonly T _value;

    public T Value
    {
        get
        {
            if (!IsSuccess)
                throw new InvalidOperationException();

            return _value;
        }
    }

    protected internal Result([AllowNull] T value, bool isSuccess, FailureReason error)
        : base(isSuccess, error)
    {
        _value = value;
    }
    
    public static implicit operator Result<T>(T value)
    {
        return Result.Ok<T>(value);
    }
    
}

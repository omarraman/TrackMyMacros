public abstract class Result
{
    public bool IsSuccess { get; protected set; }
    public bool IsFailure => !IsSuccess;
}

public abstract class Result<T> : Result
{
    private T _data;

    protected Result(T value)
    {
        Value = value;
    }

    public T Value
    {
        get => IsSuccess ? _data : throw new Exception($"You can't access .{nameof(Value)} when .{nameof(IsSuccess)} is false");
        set => _data = value;
    }
}
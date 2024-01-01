public class SuccessResult : Result
{
    public SuccessResult()
    {
        IsSuccess = true;
    }
}
public class SuccessResult<T> : Result<T>
{
    public SuccessResult(T value) : base(value)
    {
        IsSuccess = true;
    }
}

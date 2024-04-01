using FluentValidation.Results;

namespace TrackMyMacros.Application.Common;
public class ValidationErrorResult:ErrorResult
{
    public ValidationErrorResult(ValidationResult validationResult)
        :base("Validation error",validationResult.Errors.
            Select(e=>new Error(e.ErrorCode,e.ErrorMessage)).ToList())
    {
            
    }
}

public class ValidationErrorResult<T>:ErrorResult<T>
{
    public ValidationErrorResult(ValidationResult validationResult)
        :base("Validation error",validationResult.Errors.
            Select(e=>new Error(e.ErrorCode,e.ErrorMessage)).ToList())
    {
            
    }
}
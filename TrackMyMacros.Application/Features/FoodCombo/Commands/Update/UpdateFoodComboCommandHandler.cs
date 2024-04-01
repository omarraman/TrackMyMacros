using AutoMapper;
using FluentValidation.Results;
using MediatR;
using TrackMyMacros.Application.Common;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Application.Features.FoodCombo.Commands.Update;

namespace TrackMyMacros.Application.Features.FoodCombo.Commands.UpdateFood;

public class UpdateFoodComboCommandHandler:IRequestHandler<UpdateFoodComboCommand,Result>
{
    private IMapper _mapper;
    private IFoodComboRepository _foodComboRepository;

    public UpdateFoodComboCommandHandler(IMapper mapper,IFoodComboRepository FoodComboRepository)
    {
        _foodComboRepository = FoodComboRepository;
        _mapper = mapper;
    }
    

    public async Task<Result> Handle(UpdateFoodComboCommand request, CancellationToken cancellationToken)
    {
        var validator = new UpdateFoodComboCommandValidator();
        var validationResult = await validator.ValidateAsync(request);
        
        if (validationResult.Errors.Count > 0)
            return new ValidationErrorResult(validationResult);
        
        
        var foodCombo = _mapper.Map<Domain.Aggregates.FoodCombo.FoodCombo>(request);
         await _foodComboRepository.UpdateAsync(foodCombo);
        
        return new SuccessResult();
    }
    
    // public class ValidationErrorResult:ErrorResult
    // {
    //     public ValidationErrorResult(ValidationResult validationResult)
    //         :base("Validation error",validationResult.Errors.
    //             Select(e=>new Error(e.ErrorCode,e.ErrorMessage)).ToList())
    //     {
    //         
    //     }
    // }
    //
    
    // public class ValidationErrorResult:ErrorResult
    // {
    //     public ValidationErrorResult(string message, ValidationResult validationResult)
    //         :base(message,validationResult.Errors.
    //             Select(e=>new Error(e.ErrorCode,e.ErrorMessage)).ToList())
    //     {
    //         
    //     }
    // }
    
    // public class ValidationErrorResult:ErrorResult
    // {
    //     public ValidationErrorResult(Type validationType, ValidationResult validationResult)
    //         :base(nameof(validationType) + " validation error",validationResult.Errors.
    //             Select(e=>new Error(e.ErrorCode,e.ErrorMessage)).ToList())
    //     {
    //         
    //     }
    // }
    // public class UpdateFoodComboCommandValidationErrorResult:ErrorResult
    // {
    //     public UpdateFoodComboCommandValidationErrorResult(string message, IReadOnlyCollection<Error> errors)
    //         :base("UpdateFoodComboCommand validation error",errors)
    //     {
    //         
    //     }
    // }
    //
    // public class UpdateFoodComboCommandValidationErrorResult2:ValidationErrorResult
    // {
    //     public UpdateFoodComboCommandValidationErrorResult2(string message, ValidationResult validationResult)
    //         :base("UpdateFoodComboCommand validation error",validationResult)
    //     {
    //         
    //     }
    // }
}
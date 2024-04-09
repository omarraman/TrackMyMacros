
using FluentValidation;
using TrackMyMacros.Application.Features.Food.Commands.UpdateFood;

namespace TrackMyMacros.Application.Features.Food.Commands.CreateFood;

public class UpdateFoodCommandValidator:AbstractValidator<UpdateFoodCommand>
{
    public UpdateFoodCommandValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();
    }


}
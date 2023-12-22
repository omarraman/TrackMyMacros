using FluentValidation;

namespace TrackMyMacros.Application.Features.Food.Commands.CreateFood;

public class CreateFoodCommandValidator:AbstractValidator<CreateFoodCommand>
{
    public CreateFoodCommandValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();
    }


}
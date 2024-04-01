using FluentValidation;
using TrackMyMacros.Application.Features.Food.Commands.CreateFood;

namespace TrackMyMacros.Application.Features.FoodCombo.Commands.Create;

public class CreateFoodComboCommandValidator:AbstractValidator<CreateFoodComboCommand>
{
    public CreateFoodComboCommandValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();
        //must have at least one food combo amount
        RuleFor(p => p.FoodComboAmounts)
            .NotEmpty().WithMessage("You must have at least one food combo amount")
            .NotNull();
        RuleForEach(m=>m.FoodComboAmounts).SetValidator(new CreateFoodComboAmountValidator());

    }


}
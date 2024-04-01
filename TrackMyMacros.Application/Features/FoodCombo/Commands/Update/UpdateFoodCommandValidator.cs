using FluentValidation;
using TrackMyMacros.Application.Features.FoodCombo.Commands.UpdateFood;

namespace TrackMyMacros.Application.Features.FoodCombo.Commands.Update;

public class UpdateFoodComboCommandValidator:AbstractValidator<UpdateFoodComboCommand>
{
    public UpdateFoodComboCommandValidator()
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
        RuleForEach(m=>m.FoodComboAmounts).SetValidator(new UpdateFoodComboAmountValidator());

    }


}
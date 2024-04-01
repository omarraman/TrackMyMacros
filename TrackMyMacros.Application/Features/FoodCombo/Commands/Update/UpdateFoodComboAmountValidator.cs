using FluentValidation;
using TrackMyMacros.Application.Features.FoodCombo.Commands.UpdateFood;

namespace TrackMyMacros.Application.Features.FoodCombo.Commands.Update;

public class UpdateFoodComboAmountValidator:AbstractValidator<UpdateFoodComboCommand.UpdateFoodComboAmount>
{
    public UpdateFoodComboAmountValidator()
    {
        RuleFor(p => p.Quantity)
            .NotEmpty()
            .NotNull()
            .GreaterThanOrEqualTo(0);
        RuleFor(p => p.FoodId)
            .NotEmpty()
            .NotNull()
            .GreaterThanOrEqualTo(0);
    }


}
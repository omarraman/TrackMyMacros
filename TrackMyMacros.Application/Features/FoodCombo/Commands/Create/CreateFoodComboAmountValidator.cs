using FluentValidation;

namespace TrackMyMacros.Application.Features.FoodCombo.Commands.Create;

public class CreateFoodComboAmountValidator:AbstractValidator<CreateFoodComboAmount>
{
    public CreateFoodComboAmountValidator()
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
using FluentValidation;
using TrackMyMacros.Application.Features.Food.Commands.CreateFood;

namespace TrackMyMacros.Application.Features.FoodCombo.Commands.Delete;

public class DeleteFoodComboCommandValidator:AbstractValidator<DeleteFoodComboCommand>
{
    public DeleteFoodComboCommandValidator()
    {
        RuleFor(p => p.Id)
            .NotNull()
            .NotEmpty();
    }


}
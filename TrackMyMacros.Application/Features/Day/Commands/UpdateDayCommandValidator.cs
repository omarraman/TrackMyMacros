using FluentValidation;

namespace TrackMyMacros.Application.Features.Day.Commands;

public class UpdateDayCommandValidator:AbstractValidator<UpdateDayCommand>
{
    public UpdateDayCommandValidator()
    {
        RuleFor(p => p.Meals.Count > 0);
        RuleForEach(m => m.Meals).SetValidator(new UpdateMealValidator());
    }
}

public class UpdateMealValidator:AbstractValidator<UpdateDayCommand.UpdateMeal>
{
    public UpdateMealValidator()
    {
        RuleForEach(m=>m.FoodAmounts).SetValidator(new UpdateFoodAmountValidator());
    }
}

public class UpdateFoodAmountValidator:AbstractValidator<UpdateDayCommand.UpdateFoodAmount>
{
    public UpdateFoodAmountValidator()
    {
        RuleFor(p => p.Quantity)
            .GreaterThan(0);
        RuleFor(m => m.FoodId)
            .GreaterThan(0);
    }
}
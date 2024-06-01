using FluentValidation;

namespace TrackMyMacros.Application.Features.Food.Commands.CreateFood;

public class CreateFoodCommandValidator:AbstractValidator<CreateFoodCommand>
{
    public CreateFoodCommandValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();

        RuleFor(p => p.Quantity)
            .GreaterThanOrEqualTo(0);
        
        RuleFor(p => p.DefaultQuantity).GreaterThanOrEqualTo(0).When(p => p.DefaultQuantity.HasValue);
        RuleFor(p => p.DefaultQuantity).GreaterThanOrEqualTo(m=>m.Min).When(p => p.DefaultQuantity.HasValue && p.Min.HasValue);
        RuleFor(p => p.DefaultQuantity).LessThanOrEqualTo(m=>m.Max).When(p => p.DefaultQuantity.HasValue && p.Max.HasValue);
        RuleFor(p => p.Min).GreaterThanOrEqualTo(0).When(p => p.Min.HasValue);
        RuleFor(p => p.Max).GreaterThanOrEqualTo(0).When(p => p.Max.HasValue);
        RuleFor(m => m.Max).GreaterThanOrEqualTo(m => m.Min).When(m => m.Max.HasValue && m.Min.HasValue);

    }


}
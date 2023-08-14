using FluentValidation;

namespace TrackMyMacros.Application.Features.Meals.Commands.CreateMeal;

public class CreateMealCommandValidator:AbstractValidator<CreateMealCommand>
{
    public CreateMealCommandValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull();
    }

    //todo add this
    // private async Task<bool> EventNameAndDateUnique(CreateEventCommand e, CancellationToken token)
    // {
    //     return !(await _eventRepository.IsEventNameAndDateUnique(e.Name, e.Date));
    // }
}
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

    //todo add this
    // private async Task<bool> EventNameAndDateUnique(CreateEventCommand e, CancellationToken token)
    // {
    //     return !(await _eventRepository.IsEventNameAndDateUnique(e.Name, e.Date));
    // }
}
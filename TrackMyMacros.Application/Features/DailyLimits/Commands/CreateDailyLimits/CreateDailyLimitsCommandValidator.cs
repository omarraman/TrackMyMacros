using FluentValidation;

namespace TrackMyMacros.Application.Features.DailyLimits.Commands.CreateDailyLimits;

public class CreateDailyLimitsCommandValidator:AbstractValidator<CreateDailyLimitsCommand>
{
    public CreateDailyLimitsCommandValidator()
    {
        RuleFor(p => p.Carbohydrate)
            .GreaterThan(0);
        RuleFor(p => p.Fat)
            .GreaterThan(0);
        RuleFor(p => p.Protein)
            .GreaterThan(0);
        RuleFor(p => p.Calories)
            .GreaterThan(0);
    }

    //todo add this
    // private async Task<bool> EventNameAndDateUnique(CreateEventCommand e, CancellationToken token)
    // {
    //     return !(await _eventRepository.IsEventNameAndDateUnique(e.Name, e.Date));
    // }
}
using FluentValidation;

namespace TrackMyMacros.Application.Features.DailyLimits.Commands.UpdateDailyLimits;

public class UpdateDailyLimitsCommandValidator:AbstractValidator<UpdateDailyLimitsCommand>
{
    public UpdateDailyLimitsCommandValidator()
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
    // private async Task<bool> EventNameAndDateUnique(UpdateEventCommand e, CancellationToken token)
    // {
    //     return !(await _eventRepository.IsEventNameAndDateUnique(e.Name, e.Date));
    // }
}
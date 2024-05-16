using FluentValidation;

namespace TrackMyMacros.Application.Features.WeightReading.Commands.Create
{
    public class CreateWeightReadingCommandValidator : AbstractValidator<CreateWeightReadingCommand>
    {
        public CreateWeightReadingCommandValidator()
        {
            RuleFor(p => p.Weight).GreaterThan(65);
        }
    }
}
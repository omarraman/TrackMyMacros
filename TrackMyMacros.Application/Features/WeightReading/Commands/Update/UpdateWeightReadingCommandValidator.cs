using FluentValidation;

namespace TrackMyMacros.Application.Features.WeightReading.Commands.Update
{
    public class UpdateWeightReadingCommandValidator : AbstractValidator<UpdateWeightReadingCommand>
    {
        public UpdateWeightReadingCommandValidator()
        {
            RuleFor(p => p.Weight).GreaterThan(65);
            RuleFor(p => p.Id).NotEmpty().WithMessage("{PropertyName} is required").NotNull();
        }
    }
}
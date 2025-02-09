using FluentValidation;

namespace TrackMyMacros.Application.Features.Mesocycle.Commands.Update
{
    public class UpdateMesocycleCommandValidator : AbstractValidator<UpdateMesocycleCommand>
    {
        public UpdateMesocycleCommandValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required").NotNull();
            RuleFor(p => p.Id).NotEmpty().WithMessage("{PropertyName} is required").NotNull();
        }
    }
}
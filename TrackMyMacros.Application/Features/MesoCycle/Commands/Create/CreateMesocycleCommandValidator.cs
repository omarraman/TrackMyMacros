using FluentValidation;
using TrackMyMacros.Application.Features.MesoCycle.Commands.Create;

namespace TrackMyMacros.Application.Features.Mesocycle.Commands.Create
{
    public class CreateMesocycleCommandValidator : AbstractValidator<CreateMesocycleCommand>
    {
        public CreateMesocycleCommandValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required").NotNull();

        }
    }
}
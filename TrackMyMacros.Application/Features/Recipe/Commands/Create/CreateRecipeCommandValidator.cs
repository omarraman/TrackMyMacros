using FluentValidation;

namespace TrackMyMacros.Application.Features.Recipe.Commands.Create
{
    public class CreateRecipeCommandValidator : AbstractValidator<CreateRecipeCommand>
    {
        public CreateRecipeCommandValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required").NotNull();
        }
    }
}
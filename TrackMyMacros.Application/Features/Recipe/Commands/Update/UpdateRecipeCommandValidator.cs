using FluentValidation;

namespace TrackMyMacros.Application.Features.Recipe.Commands.Update
{
    public class UpdateRecipeCommandValidator : AbstractValidator<UpdateRecipeCommand>
    {
        public UpdateRecipeCommandValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required").NotNull();
            RuleFor(p => p.Id).NotEmpty().WithMessage("{PropertyName} is required").NotNull();
        }
    }
}
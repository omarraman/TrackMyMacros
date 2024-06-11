using AutoMapper;
using MediatR;
using TrackMyMacros.Application;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Common;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.Recipe.Commands.Update
{
    public class UpdateRecipeCommandHandler : IRequestHandler<UpdateRecipeCommand, Result>
    {
        private IMapper _mapper;
        private IRecipeRepository _recipeRepository;
        public UpdateRecipeCommandHandler(IMapper mapper, IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
            _mapper = mapper;
        }

        public async Task<Result> Handle(UpdateRecipeCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateRecipeCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
                return new ValidationErrorResult(validationResult);
            var recipe = _mapper.Map<Domain.Aggregates.Recipe.Recipe>(request);
            await _recipeRepository.UpdateAsync(recipe);
            return new SuccessResult();
        }
    }
}
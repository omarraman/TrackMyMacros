using AutoMapper;
using MediatR;
using TrackMyMacros.Application;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Common;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.Recipe.Commands.Create
{
    public class CreateRecipeCommandHandler : IRequestHandler<CreateRecipeCommand, Result<Guid>>
    {
        private IMapper _mapper;
        private IRecipeRepository _recipeRepository;
        public CreateRecipeCommandHandler(IMapper mapper, IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
            _mapper = mapper;
        }

        public async Task<Result<Guid>> Handle(CreateRecipeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateRecipeCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
                return new ValidationErrorResult<Guid>(validationResult);
            var entity = _mapper.Map<Domain.Aggregates.Recipe.Recipe>(request);
            entity = await _recipeRepository.AddAsync(entity);
            return new SuccessResult<Guid>(entity.Id);
        }
    }
}
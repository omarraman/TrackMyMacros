using AutoMapper;
using MediatR;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.Application;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Dtos.Recipe;

namespace TrackMyMacros.Application.Features.Recipe.Queries.Get
{
    public class GetRecipeQueryHandler : IRequestHandler<GetRecipeQuery, Maybe<GetRecipeDto>>
    {
        private IMapper _mapper;
        private IRecipeRepository _recipeRepository;
        public GetRecipeQueryHandler(IMapper mapper, IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
            _mapper = mapper;
        }

        public async Task<Maybe<GetRecipeDto>> Handle(GetRecipeQuery request, CancellationToken cancellationToken)
        {
            var results = await _recipeRepository.GetByIdAsync(request.Id);
            var mapped = results.HasValue ? _mapper.Map<GetRecipeDto>(results.Value) : Maybe<GetRecipeDto>.None;
            return mapped;
        }
    }
}
using AutoMapper;
using MediatR;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.Application;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Dtos.Recipe;

namespace TrackMyMacros.Application.Features.Recipe.Queries.GetList
{
    public class GetListRecipeQueryHandler : IRequestHandler<GetRecipeListQuery, IReadOnlyList<GetRecipeDto>>
    {
        private IMapper _mapper;
        private IRecipeRepository _recipeRepository;
        public GetListRecipeQueryHandler(IMapper mapper, IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<GetRecipeDto>> Handle(GetRecipeListQuery request, CancellationToken cancellationToken)
        {
            var results = await _recipeRepository.ListAllAsync();
            var mapped = _mapper.Map<IReadOnlyList<GetRecipeDto>>(results);
            return mapped;
        }
    }
}
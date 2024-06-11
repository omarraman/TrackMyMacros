using AutoMapper;
using TrackMyMacros.Dtos.Recipe;
using TrackMyMacros.Domain.Aggregates.Recipe;
using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Application.Profiles.Recipe
{
    public class GetRecipeMappingProfile : Profile
    {
        public GetRecipeMappingProfile()
        {
            CreateMap<Domain.Aggregates.Recipe.Recipe, GetRecipeDto>();
            CreateMap<RecipeFoodAmount, GetRecipeDto.GetRecipeFoodAmountDto>();
        }
    }
}
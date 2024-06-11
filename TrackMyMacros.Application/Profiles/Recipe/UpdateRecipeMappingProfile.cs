using AutoMapper;
using TrackMyMacros.Dtos.Recipe;
using TrackMyMacros.Domain.Aggregates.Recipe;
using TrackMyMacros.Application.Features.Recipe.Commands.Update;
using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Application.Profiles.Recipe
{
    public class UpdateRecipeMappingProfile : Profile
    {
        public UpdateRecipeMappingProfile()
        {
            CreateMap<UpdateRecipeDto, UpdateRecipeCommand>();
            CreateMap<UpdateRecipeDto.UpdateRecipeFoodAmountDto, UpdateRecipeCommand.UpdateRecipeFoodAmount>();
            CreateMap<UpdateRecipeCommand, Domain.Aggregates.Recipe.Recipe>();
            CreateMap<UpdateRecipeCommand.UpdateRecipeFoodAmount, RecipeFoodAmount>();
        }
    }
}
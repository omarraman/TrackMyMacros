using AutoMapper;
using TrackMyMacros.Dtos.Recipe;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModels.Recipe;

namespace TrackMyMacros.App4.Profiles.Recipe
{
    public class UpdateRecipeMappingProfile : Profile
    {
        public UpdateRecipeMappingProfile()
        {
            CreateMap<UpdateRecipeViewModel, UpdateRecipeDto>();
            CreateMap<FoodAmountViewModel, UpdateRecipeDto.UpdateRecipeFoodAmountDto>();

        }
    }
}
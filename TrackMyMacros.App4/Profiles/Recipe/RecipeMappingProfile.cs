using AutoMapper;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModels.Recipe;
using TrackMyMacros.Dtos.Recipe;

namespace TrackMyMacros.App4.Profiles.Recipe;

public class RecipeMappingProfile:Profile
{
    public RecipeMappingProfile()
    {
        CreateMap<RecipeViewModel, CreateRecipeDto>().ForMember(m=>m.RecipeFoodAmounts,
            opt=>opt.MapFrom(src=>src.FoodAmounts));
        CreateMap<FoodAmountViewModel, CreateRecipeDto.CreateRecipeFoodAmountDto>();
        
        CreateMap<RecipeViewModel, UpdateRecipeDto>().ForMember(m=>m.RecipeFoodAmounts,
            opt=>opt.MapFrom(src=>src.FoodAmounts));
        CreateMap<FoodAmountViewModel, UpdateRecipeDto.UpdateRecipeFoodAmountDto>();

        
        CreateMap<GetRecipeDto, RecipeViewModel>().ForMember(m=>m.FoodAmounts,
            opt
                =>opt.MapFrom(src=>src.RecipeFoodAmounts));   
        CreateMap<GetRecipeDto.GetRecipeFoodAmountDto, FoodAmountViewModel>();
    }
}
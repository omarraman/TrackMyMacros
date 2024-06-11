using AutoMapper;
using TrackMyMacros.Dtos.Recipe;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModels.Recipe;

namespace TrackMyMacros.App4.Profiles.Recipe
{
    public class CreateRecipeMappingProfile : Profile
    {
        public CreateRecipeMappingProfile()
        {
            CreateMap<CreateRecipeViewModel, CreateRecipeDto>()
                .ForMember(m=>m.RecipeFoodAmounts,
                    opt
                        =>opt.MapFrom(src=>src.FoodAmounts));
            CreateMap<FoodAmountViewModel, CreateRecipeDto.CreateRecipeFoodAmountDto>();
        }
    }
}
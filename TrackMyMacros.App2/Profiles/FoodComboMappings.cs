using AutoMapper;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;
using TrackMyMacros.Dtos.FoodCombo;

namespace TrackMyMacros.App2.Profiles;

public class FoodComboMappings : Profile
{
    public FoodComboMappings()
    {

        CreateMap<MealViewModel, CreateFoodComboDto>().ForMember(m=>m.FoodComboAmounts,
            opt=>opt.MapFrom(src=>src.FoodAmounts));
        CreateMap<FoodAmountViewModel, CreateFoodComboAmountDto>();
        
        CreateMap<MealViewModel, UpdateFoodComboDto>().ForMember(m=>m.FoodComboAmounts,
            opt=>opt.MapFrom(src=>src.FoodAmounts));
        CreateMap<FoodAmountViewModel, UpdateFoodComboDto.UpdateFoodComboAmountDto>();

        
        CreateMap<GetFoodComboDto, MealViewModel>().ForMember(m=>m.FoodAmounts,
            opt
                =>opt.MapFrom(src=>src.FoodComboAmounts));   
        CreateMap<GetFoodComboAmountDto, FoodAmountViewModel>();
    }
}
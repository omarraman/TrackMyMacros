using AutoMapper;
using TrackMyMacros.App3.ViewModels;
using TrackMyMacros.Dtos.FoodCombo;

namespace TrackMyMacros.App3.Profiles;

public class FoodComboMappings : Profile
{
    public FoodComboMappings()
    {

        CreateMap<FoodComboViewModel, CreateFoodComboDto>().ForMember(m=>m.FoodComboAmounts,
            opt=>opt.MapFrom(src=>src.FoodAmounts));
        CreateMap<FoodAmountViewModel, CreateFoodComboAmountDto>();
        
        CreateMap<FoodComboViewModel, UpdateFoodComboDto>().ForMember(m=>m.FoodComboAmounts,
            opt=>opt.MapFrom(src=>src.FoodAmounts));
        CreateMap<FoodAmountViewModel, UpdateFoodComboDto.UpdateFoodComboAmountDto>();

        
        CreateMap<GetFoodComboDto, FoodComboViewModel>().ForMember(m=>m.FoodAmounts,
            opt
                =>opt.MapFrom(src=>src.FoodComboAmounts));   
        CreateMap<GetFoodComboAmountDto, FoodAmountViewModel>();
    }
}
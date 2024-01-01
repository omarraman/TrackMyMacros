using AutoMapper;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.App2.Profiles;

public class Mappings : Profile
{
    public Mappings()
    {
        //Vms are coming in from the API, ViewModel are the local entities in Blazor
        CreateMap<FoodListItemDto, FoodListItemViewModel>().ReverseMap();
        CreateMap<UomListItemDto, UomViewModel>().ReverseMap();
        CreateMap<CreateFoodViewModel, CreateFoodDto>();
        CreateMap<GetDayDto, DayViewModel>()
            .ForMember(m=>m.Meals,
                opt=>opt.MapFrom(src=>src.GetMealDtos));
        CreateMap<GetMealDto, MealViewModel>();
        CreateMap<GetFoodAmountDto, FoodAmountViewModel>();
        
        CreateMap<DayViewModel,UpdateDayDto>()
            .ForMember(m=>m.Meals,
                opt=>opt.MapFrom(src=>src.Meals));
        CreateMap<MealViewModel, UpdateDayDto.Meal>();
        CreateMap<FoodAmountViewModel, UpdateDayDto.FoodAmount>();
        CreateMap<FoodListItemViewModel, UpdateFoodDto>();
        
        CreateMap<GetDailyLimitsDto, DailyLimitsViewModel>();
        CreateMap<DailyLimitsViewModel,UpdateDailyLimitsDto>();
    }
}
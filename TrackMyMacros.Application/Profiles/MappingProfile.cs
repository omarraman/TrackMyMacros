using AutoMapper;
using TrackMyMacros.Application.Features.DailyLimits.Commands.UpdateDailyLimits;
using TrackMyMacros.Application.Features.Day.Commands;
using TrackMyMacros.Application.Features.Food.Commands.CreateFood;
using TrackMyMacros.Application.Features.Food.Commands.UpdateFood;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.Aggregates;
using TrackMyMacros.Domain.Aggregates.DailyLimit;
using TrackMyMacros.Domain.Aggregates.Day;
using TrackMyMacros.Domain.ValueObjects;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.Application.Profiles;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Food, FoodListItemDto>().ReverseMap();
        CreateMap<CreateFoodCommand, Food>()
            .ForMember(m => m.CarbohydrateAmount, opt => opt.MapFrom(src => new CarbohydrateAmount(src.Carbohydrate)))
            .ForMember(m => m.ProteinAmount, opt => opt.MapFrom(src => new ProteinAmount(src.Protein)))
            .ForMember(m => m.FatAmount, opt => opt.MapFrom(src => new FatAmount(src.Fat)));
        
        CreateMap<UpdateFoodCommand, Food>()
            .ForMember(m => m.CarbohydrateAmount, opt => opt.MapFrom(src => new CarbohydrateAmount(src.Carbohydrate)))
            .ForMember(m => m.ProteinAmount, opt => opt.MapFrom(src => new ProteinAmount(src.Protein)))
            .ForMember(m => m.FatAmount, opt => opt.MapFrom(src => new FatAmount(src.Fat)));

        CreateMap<UpdateDailyLimitsCommand, DailyLimits>();

        CreateMap<Day, GetDayDto>().ForMember(gdd=>gdd.GetMealDtos,
            o=>o.MapFrom(gd=>gd.GetMeals()));
        
        CreateMap<Meal, GetMealDto>();
        CreateMap<FoodAmount, GetFoodAmountDto>();

        CreateMap<UpdateDayCommand, Day>().ForMember(m=>m.Meals,
            opt=>opt.MapFrom(udc=>udc.Meals));
        CreateMap<UpdateDayCommand.UpdateMeal, Meal>();
        CreateMap<UpdateDayCommand.UpdateFoodAmount, FoodAmount>();


        // CreateMap<FoodAmount, GetFoodAmountDto>().ForMember(gfad=>gfad.GetFoodDto,
        //         opt=>opt.MapFrom(gfa=>gfa.Food)
        //     );
        // CreateMap<Food, GetFoodDto>()
        //     .ForMember(gfd=>gfd.CarbohydrateAmount, 
        //     opt=>opt.MapFrom(f=>f.CarbohydrateAmount.Quantity))
        //     .ForMember(gfd=>gfd.ProteinAmount, 
        //     opt=>opt.MapFrom(f=>f.ProteinAmount.Quantity))
        //     .ForMember(gfd=>gfd.FatAmount, 
        //         opt=>opt.MapFrom(f=>f.FatAmount.Quantity));
    }
}
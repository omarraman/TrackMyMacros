using AutoMapper;
using TrackMyMacros.Application.Features.Food;
using TrackMyMacros.Application.Features.Food.Commands.CreateFood;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.Aggregates.Day;
using TrackMyMacros.Domain.ValueObjects;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.Application.Profiles;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Food, FoodListItemDto>().ReverseMap();
        CreateMap<CreateFoodCommand, Food>();

        CreateMap<Day, GetDayDto>().ForMember(gdd=>gdd.GetMealDtos,
            o=>o.MapFrom(gd=>gd.GetMeals()));
        
        CreateMap<Meal, GetMealDto>();
        CreateMap<FoodAmount, GetFoodAmountDto>();
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
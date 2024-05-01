using AutoMapper;
using TrackMyMacros.Application.Features.DailyLimits.Commands.UpdateDailyLimits;
using TrackMyMacros.Application.Features.Day.Commands;
using TrackMyMacros.Application.Features.Food.Commands.CreateFood;
using TrackMyMacros.Application.Features.Food.Commands.UpdateFood;
using TrackMyMacros.Application.Features.FoodCombo.Commands.Create;
using TrackMyMacros.Application.Features.FoodCombo.Commands.Delete;
using TrackMyMacros.Application.Features.FoodCombo.Commands.Update;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.Aggregates;
using TrackMyMacros.Domain.Aggregates.DailyLimit;
using TrackMyMacros.Domain.Aggregates.Day;
using TrackMyMacros.Domain.Aggregates.FoodCombo;
using TrackMyMacros.Domain.ValueObjects;
using TrackMyMacros.Dtos;
using TrackMyMacros.Dtos.FoodCombo;

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
        

        CreateMap<FoodCombo, GetFoodComboDto>();
        CreateMap<FoodComboAmount, GetFoodComboAmountDto>();


        CreateMap<CreateFoodComboDto, CreateFoodComboCommand>();
        CreateMap<CreateFoodComboAmount, FoodComboAmount>();
        CreateMap<CreateFoodComboCommand, FoodCombo>();
            // .ForMember(m=>m.FoodComboAmounts,
            //     o=>o.MapFrom(p=>p.FoodComboAmounts));
        // CreateMap<CreateFoodComboCommand, FoodCombo>()
        //     .ForMember(m=>m.FoodComboAmounts,
        //         o=>o.MapFrom(p=>p.FoodComboAmounts));

        
        CreateMap<CreateFoodComboAmountDto, CreateFoodComboAmount>();
        
        
        
        CreateMap<UpdateFoodComboCommand, FoodCombo>().ForMember(m=>m.FoodComboAmounts,
            o=>o.MapFrom(p=>p.FoodComboAmounts));
        CreateMap<UpdateFoodComboCommand.UpdateFoodComboAmount, FoodComboAmount>()
            .ForMember(m=>m.FoodId,o=>o.MapFrom(p=>p.FoodId))
            .ForMember(m=>m.Quantity,o=>o.MapFrom(p=>p.Quantity))
            ;

    }
}
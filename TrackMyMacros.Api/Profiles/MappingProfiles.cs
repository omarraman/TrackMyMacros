using AutoMapper;
using TrackMyMacros.Application.Features.DailyLimits.Commands.UpdateDailyLimits;
using TrackMyMacros.Application.Features.Day.Commands;
using TrackMyMacros.Application.Features.Food.Commands.CreateFood;
using TrackMyMacros.Application.Features.Food.Commands.UpdateFood;
using TrackMyMacros.Application.Features.FoodCombo.Commands.Delete;
using TrackMyMacros.Application.Features.FoodCombo.Commands.Update;
using TrackMyMacros.Dtos;
using TrackMyMacros.Dtos.FoodCombo;

namespace TrackMyMacros.Api.Profiles;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateFoodDto, CreateFoodCommand>();
        CreateMap<UpdateDayDto, UpdateDayCommand>()
            .ForMember(m => m.Meals, opt => opt.MapFrom(src => src.Meals));
        CreateMap<UpdateDayDto.Meal, UpdateDayCommand.UpdateMeal>();
        CreateMap<UpdateDayDto.FoodAmount, UpdateDayCommand.UpdateFoodAmount>();
        // CreateMap<CreateDailyLimitsDto, CreateDailyLimitsCommand>();
        CreateMap<UpdateDailyLimitsDto, UpdateDailyLimitsCommand>();
        CreateMap<UpdateFoodDto, UpdateFoodCommand>();
        CreateMap<UpdateFoodComboDto, UpdateFoodComboCommand>();
        CreateMap<UpdateFoodComboDto.UpdateFoodComboAmountDto, UpdateFoodComboCommand.UpdateFoodComboAmount>();
        CreateMap<DeleteFoodComboDto, DeleteFoodComboCommand>();
    }
}
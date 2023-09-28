using AutoMapper;
using TrackMyMacros.Application.Features.Day.Commands;
using TrackMyMacros.Application.Features.Food.Commands.CreateFood;
using TrackMyMacros.Dtos;

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

    }
}
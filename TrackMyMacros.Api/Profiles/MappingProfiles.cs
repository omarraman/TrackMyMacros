using AutoMapper;
using TrackMyMacros.Application.Features.Food.Commands.CreateFood;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.Api.Profiles;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateFoodDto, CreateFoodCommand>();

    }
}
using AutoMapper;
using TrackMyMacros.App2.Components;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.App2.Profiles;

public class Mappings : Profile
{
    public Mappings()
    {
        //Vms are coming in from the API, ViewModel are the local entities in Blazor
        CreateMap<FoodListItemDto, FoodListViewModel>().ReverseMap();
        CreateMap<UomListItemDto, UomViewModel>().ReverseMap();
        CreateMap<CreateFoodViewModel, CreateFoodDto>();
    }
}
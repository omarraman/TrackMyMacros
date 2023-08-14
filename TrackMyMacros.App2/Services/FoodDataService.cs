using AutoMapper;
using Blazored.LocalStorage;
using Flurl.Http;
using TrackMyMacros.App2.Components;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.App2.Services;

public interface IFoodDataService
{
    Task<IReadOnlyList<FoodListViewModel>> GetFoods( );
    Task AddFood(CreateFoodViewModel dto);
}

public class FoodDataService :IFoodDataService
{
     private readonly IMapper _mapper;

    public FoodDataService( IMapper mapper) 
    {
        _mapper = mapper;
    }


    public async Task<IReadOnlyList<FoodListViewModel>> GetFoods( )
    {
        
        // headers.Add("ApiKey",_options.Value.ApiKey);
        // if (_options.Value.Host!=null)
        // {
        //     headers.Add("host",_options.Value.Host);
        // }
            
        var uri =  "https://localhost:7115/api/Food";
        var foods = await uri
            .GetJsonAsync<IReadOnlyList<FoodListViewModel>>();
        var mappedFoods = _mapper.Map<IReadOnlyList<FoodListViewModel>>(foods);

        return mappedFoods;

    }

    public async Task AddFood(CreateFoodViewModel model)
    {
        var dto = _mapper.Map<CreateFoodDto>(model);
        var uri =  "https://localhost:7115/api/Food";
         await uri
            .PostJsonAsync(dto);
        
        
    }


}
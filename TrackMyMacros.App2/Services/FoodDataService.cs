using AutoMapper;
using Flurl.Http;
using TrackMyMacros.App2.Interfaces;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.App2.Services;

public class FoodDataService :IFoodDataService
{
     private readonly IMapper _mapper;

    public FoodDataService( IMapper mapper) 
    {
        _mapper = mapper;
    }


    public async Task<IReadOnlyList<FoodListItemViewModel>> GetFoods( )
    {
        
        // headers.Add("ApiKey",_options.Value.ApiKey);
        // if (_options.Value.Host!=null)
        // {
        //     headers.Add("host",_options.Value.Host);
        // }
            
        var uri =  "https://localhost:7115/api/Food";
        var foods = await uri
            .GetJsonAsync<IReadOnlyList<FoodListItemViewModel>>();
        var mappedFoods = _mapper.Map<IReadOnlyList<FoodListItemViewModel>>(foods);

        return mappedFoods.OrderBy(m=>m.Name).ToList();

    }

    public async Task AddFood(CreateFoodViewModel model)
    {
        var dto = _mapper.Map<CreateFoodDto>(model);
        var uri =  "https://localhost:7115/api/Food";
         await uri
            .PostJsonAsync(dto);
        
    }

    
    public async Task UpdateFood(FoodListItemViewModel model)
    {
        var dto = _mapper.Map<UpdateFoodDto>(model);
        var uri =  "https://localhost:7115/api/Food";
        await uri
            .PutJsonAsync(dto);
        
    }

}
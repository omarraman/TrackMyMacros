using System.Net;
using AutoMapper;
using Flurl.Http;
using Microsoft.Extensions.Options;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;
using TrackMyMacros.Dtos.FoodCombo;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App2.Services;

public class FoodComboDataService_tem: IFoodComboDataService
{
    private readonly IMapper _mapper;
    private readonly string? _baseUrl;

    public FoodComboDataService_tem(IMapper mapper,IConfiguration configuration)
    {
        _baseUrl = configuration["BackendUrl"];
        _mapper = mapper;
    }

    public async Task CreateMealCombo(MealViewModel mealViewModel,string name)
    {
            var createFoodComboDto = _mapper.Map<CreateFoodComboDto>(mealViewModel);
            createFoodComboDto.Name = name;
            var uri = $"{_baseUrl}/api/FoodCombo";
            await uri
                .PostJsonAsync(createFoodComboDto);
    }
    
    public async Task UpdateMealCombo(MealViewModel mealViewModel,string name,Guid id)
    {
            var updateFoodComboDto = _mapper.Map<UpdateFoodComboDto>(mealViewModel);
            updateFoodComboDto.Name = name;
            updateFoodComboDto.Id = id;
            var uri = $"{_baseUrl}/api/FoodCombo";
            await uri
                .PutJsonAsync(updateFoodComboDto);
    }
    public async Task<IReadOnlyList<MealViewModel>> GetAllMealCombos()
    {
            var uri = $"{_baseUrl}/api/FoodCombo";
            var dtoList = await uri
                .GetJsonAsync<IReadOnlyList<GetFoodComboDto>>();
            return _mapper.Map<IReadOnlyList<MealViewModel>>(dtoList);
    }
    
    public async Task<MealViewModel> GetMealCombo(Guid id)
    {
            var uri = $"{_baseUrl}/api/FoodCombo/GetById/{id}";
            var dto= await uri
                .GetJsonAsync<GetFoodComboDto>();
            var mealViewModel = _mapper.Map<MealViewModel>(dto);
            return mealViewModel;
    }
    
    public async Task DeleteMealCombo(Guid id)
    {
            var uri = $"{_baseUrl}/api/FoodCombo/{id}";
            await uri
                .DeleteAsync();
    }
}

public interface IFoodComboDataService
{
    Task CreateMealCombo(MealViewModel mealViewModel,string name);
    Task<IReadOnlyList<MealViewModel>> GetAllMealCombos();
    Task<MealViewModel> GetMealCombo(Guid guid);
    Task UpdateMealCombo(MealViewModel mealViewModel,string name,Guid id);
    Task DeleteMealCombo(Guid id);
}
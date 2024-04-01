using System.Net;
using AutoMapper;
using Flurl.Http;
using Microsoft.Extensions.Options;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;
using TrackMyMacros.Dtos.FoodCombo;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App2.Services;

public class FoodComboDataService: IFoodComboDataService
{
    private readonly IMapper _mapper;
    private readonly string? _baseUrl;

    public FoodComboDataService(IMapper mapper,IConfiguration configuration)
    {
        _baseUrl = configuration["BackendUrl"];
        _mapper = mapper;
    }


    // public async Task<Maybe<T>> GetDay<T>(DateOnly date)
    // {
    //     var uri = $"{_baseUrl}/api/Day?date={date.ToString("yyyy-MM-dd")}";
    //
    //
    //     GetDayDto day;
    //     try
    //     {
    //         day = await uri
    //             .GetJsonAsync<GetDayDto>();
    //         var dayViewModel = _mapper.Map<T>(day);
    //
    //         return dayViewModel;
    //     }
    //     catch (FlurlHttpException e)
    //     {
    //         if (e.Call?.Response.StatusCode == (int)HttpStatusCode.NotFound)
    //         {
    //             return Maybe<T>.None;
    //         }
    //
    //         throw;
    //     }
    // }

    
    public async Task CreateMealCombo(MealViewModel mealViewModel,string name)
    {
        try
        {
            var createFoodComboDto = _mapper.Map<CreateFoodComboDto>(mealViewModel);
            createFoodComboDto.Name = name;
            var uri = $"{_baseUrl}/api/FoodCombo";
            await uri
                .PostJsonAsync(createFoodComboDto);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
    
    public async Task UpdateMealCombo(MealViewModel mealViewModel,string name,Guid id)
    {
        try
        {
            var updateFoodComboDto = _mapper.Map<UpdateFoodComboDto>(mealViewModel);
            updateFoodComboDto.Name = name;
            updateFoodComboDto.Id = id;
            var uri = $"{_baseUrl}/api/FoodCombo";
            await uri
                .PutJsonAsync(updateFoodComboDto);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
    public async Task<IReadOnlyList<GetFoodComboDto>> GetAllMealCombos()
    {
        try
        {
            var uri = $"{_baseUrl}/api/FoodCombo";
            return await uri
                .GetJsonAsync<IReadOnlyList<GetFoodComboDto>>();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
    
    public async Task<GetFoodComboDto> GetMealCombo(Guid id)
    {
        try
        {
            var uri = $"{_baseUrl}/api/FoodCombo/GetById/{id}";
            return await uri
                .GetJsonAsync<GetFoodComboDto>();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
    
    
    public async Task<MealViewModel> GetMealCombo2(Guid id)
    {
        
        var dto = await GetMealCombo(id);
        var mealViewModel = _mapper.Map<MealViewModel>(dto);
        return mealViewModel;
    }
    
    
    public async Task DeleteMealCombo(Guid id)
    {
        try
        {
            var uri = $"{_baseUrl}/api/FoodCombo/{id}";
            await uri
                .DeleteAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
}

public interface IFoodComboDataService
{
    Task CreateMealCombo(MealViewModel mealViewModel,string name);
    Task<IReadOnlyList<GetFoodComboDto>> GetAllMealCombos();
    Task<GetFoodComboDto> GetMealCombo(Guid guid);
    Task UpdateMealCombo(MealViewModel mealViewModel,string name,Guid id);
    Task DeleteMealCombo(Guid id);
    Task<MealViewModel> GetMealCombo2(Guid id);
}
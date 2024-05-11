using AutoMapper;
using Flurl.Http;
using TrackMyMacros.App2.Interfaces;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.App2.Services;

public class FoodDataService :IFoodDataService
{
     private readonly IMapper _mapper;
     private IConfiguration _configuration;
     private readonly string? _baseUrl;

     public FoodDataService( IMapper mapper,IConfiguration configuration)
     {
         _baseUrl = configuration["BackendUrl"];
         if (_baseUrl==null)
         {
             throw new ArgumentNullException(nameof(_baseUrl));
         }
         
         _mapper = mapper;
     }


    public async Task<IReadOnlyList<FoodListItemViewModel>> GetFoods( )
    {
        
        // headers.Add("ApiKey",_options.Value.ApiKey);
        // if (_options.Value.Host!=null)
        // {
        //     headers.Add("host",_options.Value.Host);
        // }
            
        var uri =  _baseUrl + "/api/Food";
        var foods = await uri
            .GetJsonAsync<IReadOnlyList<FoodListItemViewModel>>();
        var mappedFoods = _mapper.Map<IReadOnlyList<FoodListItemViewModel>>(foods);

        return mappedFoods.OrderBy(m=>m.Name).ToList();

    }

    public class ProblemDetails
    {
        public string? Type { get; set; }
        public string? Title { get; set; }
        public int? Status { get; set; }
        public string? Detail { get; set; }
        public string? Instance { get; set; }
    }


    public async Task AddFood(CreateFoodViewModel model)
    {
        try
        {
            var dto = _mapper.Map<CreateFoodDto>(model);
            var uri = _baseUrl + "/api/Food";
            await uri
                .PostJsonAsync(dto);
        }
        catch (FlurlHttpException ex)
        {
            var string1 = await ex.GetResponseStringAsync();
            throw new Exception(string1);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }


    }

    
    public async Task Post<TModel,TDto>(TModel model,string endpoint)
    {
        try
        {
            var dto = _mapper.Map<TDto>(model);
            var uri = _baseUrl + endpoint;
            await uri
                .PostJsonAsync(dto);
        }
        catch (FlurlHttpException ex)
        {
            var string1 = await ex.GetResponseStringAsync();
            throw new Exception(string1);
        }
    }
    
    
    public async Task Put<TModel,TDto>(TModel model,string endpoint)
    {
        try
        {
            var dto = _mapper.Map<TDto>(model);
            var uri = _baseUrl + endpoint;
            await uri
                .PostJsonAsync(dto);
        }
        catch (FlurlHttpException ex)
        {
            var string1 = await ex.GetResponseStringAsync();
            throw new Exception(string1);
        }
    }
    
    public async Task<IReadOnlyList<TModel>> GetList<TModel,TDto>(string endpoint )
    {
        try
        {
            var uri =  _baseUrl + endpoint;
            var foods = await uri
                .GetJsonAsync<IReadOnlyList<TDto>>();
            return _mapper.Map<IReadOnlyList<TModel>>(foods);
        }
        catch (FlurlHttpException ex)
        {
            var string1 = await ex.GetResponseStringAsync();
            throw new Exception(string1);
        }

    }
    
    public async Task<TModel> Get<TModel,TDto>(string endpoint )
    {
        try
        {
            var uri =  _baseUrl + endpoint;
            var foods = await uri
                .GetJsonAsync<TDto>();
            return _mapper.Map<TModel>(foods);
        }
        catch (FlurlHttpException ex)
        {
            var string1 = await ex.GetResponseStringAsync();
            throw new Exception(string1);
        }

    }

    public async Task UpdateFood(FoodListItemViewModel model)
    {
        var dto = _mapper.Map<UpdateFoodDto>(model);
        var uri =  _baseUrl + "/api/Food";
        await uri
            .PutJsonAsync(dto);
        
    }

}
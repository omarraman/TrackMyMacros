using AutoMapper;
using Flurl.Http;

namespace TrackMyMacros.App3;

public interface IGenericDataService
{
    Task Post<TModel,TDto>(TModel model,string endpoint);
    Task Put<TModel,TDto>(TModel model,string endpoint);
    Task<IReadOnlyList<TModel>> GetList<TModel,TDto>(string endpoint );
    Task<TModel> Get<TModel,TDto>(string endpoint );
}

public class GenericDataService :IGenericDataService
{
    private readonly IMapper _mapper;
    private readonly string? _baseUrl;

    public GenericDataService( IMapper mapper,IConfiguration configuration)
    {
        _baseUrl = configuration["BackendUrl"];
        if (_baseUrl==null)
        {
            throw new ArgumentNullException(nameof(_baseUrl));
        }
         
        _mapper = mapper;
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

}
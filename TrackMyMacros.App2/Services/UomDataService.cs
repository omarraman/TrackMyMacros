using Ardalis.GuardClauses;
using AutoMapper;
using Flurl.Http;
using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Services;

public interface IUomDataService
{
    public Task<IReadOnlyList<UomViewModel>> GetUoms( );
}

public class UomDataService :IUomDataService
{
     private readonly IMapper _mapper;
     private readonly string? _baseUrl;

     public UomDataService( IMapper mapper,IConfiguration configuration) 
    {
        _baseUrl = Guard.Against.NullOrEmpty(configuration["BackendUrl"]) ;
        
        _mapper = mapper;
    }


    public async Task<IReadOnlyList<UomViewModel>> GetUoms( )
    {
        
        // headers.Add("ApiKey",_options.Value.ApiKey);
        // if (_options.Value.Host!=null)
        // {
        //     headers.Add("host",_options.Value.Host);
        // }
            
        var uri =  _baseUrl + "/api/Uom";
        // var uri =  "https://localhost:7115/api/Uom";
        var foods = await uri
            .GetJsonAsync<IReadOnlyList<UomViewModel>>();
        var mappedUoms = _mapper.Map<IReadOnlyList<UomViewModel>>(foods);

        return mappedUoms;

    }
    

}
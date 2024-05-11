using AutoMapper;
using Flurl.Http;

namespace TrackMyMacros.App3.Services;

public class LogDataService : ILogDataService
{
    private readonly string? _baseUrl;

    public LogDataService(IMapper mapper, IConfiguration configuration)
    {
        _baseUrl = configuration["BackendUrl"];
    }


    public async Task<string> GetLogs()
    {
        try
        {
            var uri = $"{_baseUrl}/api/developer";
            return await uri
                .GetStringAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
}

public interface ILogDataService
{
    Task<string> GetLogs();
}
    

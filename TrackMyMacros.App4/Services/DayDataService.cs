using System.Net;
using AutoMapper;
using Flurl.Http;
using TrackMyMacros.Dtos;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.Services
{
    public class DayDataService
    {
        private readonly IMapper _mapper;
        private readonly string? _baseUrl;

        public DayDataService(IMapper mapper,IConfiguration configuration)
        {
            _baseUrl = configuration["BackendUrl"];
            _mapper = mapper;
        }


        public async Task<Maybe<T>> GetDay<T>(DateOnly date)
        {
            var uri = $"{_baseUrl}/api/Day?date={date.ToString("yyyy-MM-dd")}";


            GetDayDto day;
            try
            {
                day = await uri
                    .GetJsonAsync<GetDayDto>();
                var dayViewModel = _mapper.Map<T>(day);

                return dayViewModel;
            }
            catch (FlurlHttpException e)
            {
                if (e.Call?.Response.StatusCode == (int)HttpStatusCode.NotFound)
                {
                    return Maybe<T>.None;
                }

                throw;
            }
        }

    
        public async Task UpdateDay<T>(T dayViewModel)
        {
            try
            {
                var updateDpdateDayDto = _mapper.Map<UpdateDayDto>(dayViewModel);
                var uri = $"{_baseUrl}/api/Day";
                await uri
                    .PostJsonAsync(updateDpdateDayDto);
            }
            catch (FlurlHttpException e)
            {
                Console.WriteLine("Bollox " + e);
                throw;
            }
        }
    }
}
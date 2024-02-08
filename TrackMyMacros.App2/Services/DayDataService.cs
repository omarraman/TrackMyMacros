using System.Net;
using AutoMapper;
using Flurl.Http;
using Microsoft.Extensions.Options;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App2.Services;

public class DayDataService
{
    private readonly IMapper _mapper;
    private readonly string? _baseUrl;

    public DayDataService(IMapper mapper,IConfiguration configuration)
    {
        _baseUrl = configuration["BackendUrl"];
        _mapper = mapper;
    }


    // public async Task<Result<DayViewModel>> GetDay(DateOnly date )
    // {
    //     var uri =  $"https://localhost:7115/api/Day?date={date.ToString("yyyy-MM-dd")}";
    //
    //
    //     GetDayDto day;
    //     try
    //     {
    //         day = await uri
    //             .GetJsonAsync<GetDayDto>();
    //     }
    //     catch (FlurlHttpException e)
    //     {
    //         if (e.Call?.Response.StatusCode==(int)HttpStatusCode.NotFound)
    //         {
    //             return new NoDayAtDateErrorResult("There is no day at that date");
    //         }
    //
    //     }
    //     
    //
    //     var dayViewModel = _mapper.Map<DayViewModel>(day);
    //     
    //     return new SuccessResult<DayViewModel>(dayViewModel);
    // }


    // public async Task<Maybe<DayViewModel>> GetDay(DateOnly date)
    // {
    //     var uri = $"https://localhost:7115/api/Day?date={date.ToString("yyyy-MM-dd")}";
    //
    //
    //     GetDayDto day;
    //     try
    //     {
    //         day = await uri
    //             .GetJsonAsync<GetDayDto>();
    //         var dayViewModel = _mapper.Map<DayViewModel>(day);
    //
    //         return dayViewModel;
    //     }
    //     catch (FlurlHttpException e)
    //     {
    //         if (e.Call?.Response.StatusCode == (int)HttpStatusCode.NotFound)
    //         {
    //             return Maybe<DayViewModel>.None;
    //         }
    //
    //         throw;
    //     }
    // }

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
    
    
    // public async Task UpdateDay(DayViewModel dayViewModel)
    // {
    //     try
    //     {
    //         var updateDpdateDayDto = _mapper.Map<UpdateDayDto>(dayViewModel);
    //         var uri = "https://localhost:7115/api/Day";
    //         await uri
    //             .PostJsonAsync(updateDpdateDayDto);
    //     }
    //     catch (FlurlHttpException e)
    //     {
    //         Console.WriteLine("Bollox " + e);
    //         throw;
    //     }
    // }
    
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
using System.Net;
using AutoMapper;
using Blazored.LocalStorage;
using CSharpFunctionalExtensions;
using Flurl.Http;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.App2.Services;

public interface IDailyLimitsDataService
{
    public Task<Result<DailyLimitsViewModel>> GetDailyLimits();
}

public class DailyLimitsDataService : IDailyLimitsDataService
{
    private readonly IMapper _mapper;

    public DailyLimitsDataService(IMapper mapper)
    {
        _mapper = mapper;
    }


    public async Task<Result<DailyLimitsViewModel>> GetDailyLimits()
    {
        var uri = "https://localhost:7115/api/DailyLimits";
        try
        {
            var dailyLimits = await uri
                .GetJsonAsync<GetDailyLimitsDto>();
            var mappedDailyLimitss = _mapper.Map<DailyLimitsViewModel>(dailyLimits);

            return mappedDailyLimitss;
        }
        catch (FlurlHttpException ex)
        {
            if (ex.Call.Response.StatusCode ==404)
            {
                
            }
            // var y = Result.Failure<>()
            // var y = new  Error
            // var x = new Result<DailyLimitsViewModel,>();
            return Result.Failure<DailyLimitsViewModel>("Failed to get daily limits.");
        }
    }
}
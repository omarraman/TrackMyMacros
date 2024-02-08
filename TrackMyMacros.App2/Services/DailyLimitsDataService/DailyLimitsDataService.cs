using System.Net;
using AutoMapper;
using Flurl.Http;
using Microsoft.Extensions.Options;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App2.Services.DailyLimitsDataService;

public interface IDailyLimitsDataService
{
    public Task<Maybe<DailyLimitsViewModel>> GetDailyLimits();
    Task<Result> UpdateDailyLimits(DailyLimitsViewModel dailyLimitsViewModel);
}

public class DailyLimitsDataService : IDailyLimitsDataService
{
    private readonly IMapper _mapper;
    private readonly string? _baseUrl;

    public DailyLimitsDataService(IMapper mapper,IConfiguration configuration)
    {
        _baseUrl = configuration["BackendUrl"];

        _mapper = mapper;
    }


    public async Task<Maybe<DailyLimitsViewModel>> GetDailyLimits()
    {
        var uri = _baseUrl + "/api/DailyLimits";
        try
        {
            var dailyLimits = await uri
                .GetJsonAsync<GetDailyLimitsDto>();
            var mappedDailyLimitss = _mapper.Map<DailyLimitsViewModel>(dailyLimits);

            return mappedDailyLimitss;
        }
        catch (FlurlHttpException ex)
        {
            if (ex.Call?.Response?.StatusCode == 404)
            {
                return Maybe<DailyLimitsViewModel>.None;
            }

            throw ex;
        }
    }

    public async Task<Result> UpdateDailyLimits(DailyLimitsViewModel dailyLimitsViewModel)
    {

        try
        {
            var uri = _baseUrl + "/api/DailyLimits";

            var dto = _mapper.Map<UpdateDailyLimitsDto>(dailyLimitsViewModel);
            await uri
                .PutJsonAsync(dto);
            return new SuccessResult();
        }
        catch (FlurlHttpException e)
        {
            if (e.Call.Response.StatusCode == (int)HttpStatusCode.BadRequest)
            {
                return new BadArgumentErrorResult("Invalid argument error.");
            }

            throw;
        }

    }
}
using System.Net;
using AutoMapper;
using Flurl.Http;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.App2.Services.DailyLimitsDataService;

public interface IDailyLimitsDataService
{
    public Task<Result<DailyLimitsViewModel>> GetDailyLimits();
    Task<Result> UpdateDailyLimits(DailyLimitsViewModel dailyLimitsViewModel);
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

            return new SuccessResult<DailyLimitsViewModel>(mappedDailyLimitss);
        }
        catch (FlurlHttpException ex)
        {
            if (ex.Call?.Response.StatusCode == 404)
            {
                return new NoDailyLimitRecordFoundErrorResult("No daily limit record found.");
            }

            throw ex;
        }
    }

    public async Task<Result> UpdateDailyLimits(DailyLimitsViewModel dailyLimitsViewModel)
    {

        try
        {
            var uri = "https://localhost:7115/api/DailyLimits";
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
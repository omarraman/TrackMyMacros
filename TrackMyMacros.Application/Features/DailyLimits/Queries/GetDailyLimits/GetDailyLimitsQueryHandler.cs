using AutoMapper;

using Dapper;
using MediatR;
using Npgsql;
using TrackMyMacros.Application.Utils;
using TrackMyMacros.Dtos;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.Application.Features.DailyLimits.Queries.GetDailyLimits;



public class GetDailyLimitsQueryHandler: IRequestHandler<GetDailyLimitsQuery,Maybe<GetDailyLimitsDto>>
{
    private IMapper _mapper;
    private ConnectionString _connectionString;

    public GetDailyLimitsQueryHandler(IMapper mapper,ConnectionString connectionString)
    {
        _connectionString = connectionString;
        _mapper = mapper;
    }
    
    public async Task<Maybe<GetDailyLimitsDto>> Handle(GetDailyLimitsQuery request, CancellationToken cancellationToken)
    {
        using var connection = new NpgsqlConnection(_connectionString.Value);

        var sql = "SELECT * FROM public.\"DailyLimits\"";

        var dailyLimits = connection.Query<GetDailyLimitsDto>(sql);
        if (!dailyLimits.Any())
        {
            return Maybe.None;
        }

        return dailyLimits.First();

    }
}
using AutoMapper;
using Dapper;
using MediatR;
using Npgsql;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Application.Utils;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.Application.Features.Uom.Queries.GetUomList;



public class GetUomListQueryHandler: IRequestHandler<GetUomListQuery,IReadOnlyList<UomListItemDto>>
{
    private IMapper _mapper;
    private ConnectionString _connectionString;

    public GetUomListQueryHandler(IMapper mapper,ConnectionString connectionString,IUomRepository UomRepository)
    {
        _connectionString = connectionString;
        _mapper = mapper;
    }
    
    public async Task<IReadOnlyList<UomListItemDto>> Handle(GetUomListQuery request, CancellationToken cancellationToken)
    {
        using var connection = new NpgsqlConnection(_connectionString.Value);

        var sql = "SELECT * FROM public.\"Uoms\"";

        IReadOnlyList<UomListItemDto> list = connection.Query<UomListItemDto>(sql).ToList().AsReadOnly();

        return list;
        // List<UomListDto> UomListVms = new();
        // var allUom = (await _UomRepository.ListAllAsync()).OrderBy(m=>m.Id);
        // UomListVms = _mapper.Map<List<UomListDto>>(allUom);
        // return UomListVms;
    }
}
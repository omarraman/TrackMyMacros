using AutoMapper;
using Dapper;
using MediatR;
using Npgsql;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Application.Utils;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.Application.Features.Food.Queries.GetFoodList;

public class GetFoodListQueryHandler: IRequestHandler<GetFoodListQuery,IReadOnlyList<FoodListItemDto>>
{
    private IMapper _mapper;
    private IFoodRepository _foodRepository;
    private ConnectionString _connectionString;

    public GetFoodListQueryHandler(IMapper mapper,ConnectionString connectionString,IFoodRepository foodRepository)
    {
        _connectionString = connectionString;
        _foodRepository = foodRepository;
        _mapper = mapper;
    }
    
    public async Task<IReadOnlyList<FoodListItemDto>> Handle(GetFoodListQuery request, CancellationToken cancellationToken)
    {
        using var connection = new NpgsqlConnection(_connectionString.Value);

        var sql = "SELECT f.\"Id\", f.\"Name\",f.\"ProteinAmount\",f.\"FatAmount\",f.\"CarbohydrateAmount\",f.\"Quantity\",u.\"Name\" as UOM FROM public.\"Food\" f join public.\"Uoms\" u on u.\"Id\" = f.\"UomId\"";

         IReadOnlyList<FoodListItemDto> list = connection.Query<FoodListItemDto>(sql).ToList().AsReadOnly();

         return list;
         // List<FoodListDto> foodListVms = new();
         // var allFood = (await _foodRepository.ListAllAsync()).OrderBy(m=>m.Id);
         // foodListVms = _mapper.Map<List<FoodListDto>>(allFood);
         // return foodListVms;
    }
}
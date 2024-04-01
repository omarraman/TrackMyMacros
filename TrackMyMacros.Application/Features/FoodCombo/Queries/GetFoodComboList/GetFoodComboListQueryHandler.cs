using AutoMapper;
using Dapper;
using MediatR;
using Npgsql;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Application.Features.Food.Queries.GetFoodList;
using TrackMyMacros.Dtos;
using TrackMyMacros.Dtos.FoodCombo;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.Application.Features.Food.Queries.GetFoodCombo;

public class GetFoodComboListQueryHandler: IRequestHandler<GetFoodComboListQuery,IReadOnlyList<GetFoodComboDto>>
{
    private IMapper _mapper;
    private IFoodComboRepository _foodComboRepository;

    public GetFoodComboListQueryHandler(IMapper mapper,IFoodComboRepository foodComboRepository)
    {
        _foodComboRepository = foodComboRepository;
        _mapper = mapper;
    }
    
    public async Task<IReadOnlyList<GetFoodComboDto>> Handle(GetFoodComboListQuery request, CancellationToken cancellationToken)
    {
        var results = await _foodComboRepository.ListAllAsync();
        var mapped = _mapper.Map<IReadOnlyList<GetFoodComboDto>>(results);
        return mapped;
    }
}
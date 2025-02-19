using AutoMapper;
using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Dtos.FoodCombo;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Features.FoodCombo.Queries.GetFoodCombo;

public class GetFoodComboQueryHandler: IRequestHandler<GetFoodComboQuery,Maybe<GetFoodComboDto>>
{
    private IMapper _mapper;
    private IFoodComboRepository _foodComboRepository;

    public GetFoodComboQueryHandler(IMapper mapper,IFoodComboRepository foodComboRepository)
    {
        _foodComboRepository = foodComboRepository;
        _mapper = mapper;
    }
    
    public async Task<Maybe<GetFoodComboDto>> Handle(GetFoodComboQuery request, CancellationToken cancellationToken)
    {
        var results = await _foodComboRepository.GetByIdAsync(request.Id);
        var mapped = results.HasValue? _mapper.Map<GetFoodComboDto>(results.Value):Maybe<GetFoodComboDto>.None;
        return mapped;
    }
}
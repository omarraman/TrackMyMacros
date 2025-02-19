using TrackMyMacros.Dtos;
using TrackMyMacros.Dtos.FoodCombo;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Features.FoodCombo.Queries.GetFoodCombo;

public class GetFoodComboQuery:RequestBase<Maybe<GetFoodComboDto>>
{
    public Guid Id { get; set; }
}
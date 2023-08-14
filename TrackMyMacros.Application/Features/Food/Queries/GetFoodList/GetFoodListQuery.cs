using MediatR;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.Application.Features.Food.Queries.GetFoodList;

public class GetFoodListQuery:IRequest<IReadOnlyList<FoodListItemDto>>
{
    
}
using MediatR;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.Application.Features.Uom.Queries.GetUomList;

public class GetUomListQuery:RequestBase<IReadOnlyList<UomListItemDto>>
{
    
}
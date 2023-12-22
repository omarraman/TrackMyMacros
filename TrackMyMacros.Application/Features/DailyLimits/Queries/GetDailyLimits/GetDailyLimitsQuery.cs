using CSharpFunctionalExtensions;
using MediatR;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.Application.Features.DailyLimits.Queries.GetDailyLimits;

public class GetDailyLimitsQuery:IRequest<Maybe<GetDailyLimitsDto>>
{
    
}
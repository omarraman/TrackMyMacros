using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.Application.Features.Mesocycle.Queries.Get
{
    public class GetMesocycleQuery : RequestBase<Maybe<GetMesocycleDto>>
    {
        public Guid Id { get; set; }
    }
}
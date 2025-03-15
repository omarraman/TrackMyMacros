using AutoMapper;
using TrackMyMacros.Dtos.Set;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

namespace TrackMyMacros.Application.Profiles.Set
{
    public class GetSetMappingProfile : Profile
    {
        public GetSetMappingProfile()
        {
            CreateMap<TrackMyMacros.Domain.Aggregates.Mesocycle.Set, GetSetDto>();
        }
    }
}
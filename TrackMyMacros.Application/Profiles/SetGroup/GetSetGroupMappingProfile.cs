using AutoMapper;
using TrackMyMacros.Dtos.SetGroup;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

namespace TrackMyMacros.Application.Profiles.SetGroup
{
    public class GetSetGroupMappingProfile : Profile
    {
        public GetSetGroupMappingProfile()
        {
            CreateMap<TrackMyMacros.Domain.Aggregates.Mesocycle.SetGroup, GetSetGroupDto>();
        }
    }
}
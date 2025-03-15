using AutoMapper;
using TrackMyMacros.Dtos.Set;

namespace TrackMyMacros.Application.Profiles.ExerciseDaySet
{
    public class GetSetMappingProfile : Profile
    {
        public GetSetMappingProfile()
        {
            CreateMap<TrackMyMacros.Domain.Aggregates.Mesocycle.Set, GetSetDto>();
        }
    }
}
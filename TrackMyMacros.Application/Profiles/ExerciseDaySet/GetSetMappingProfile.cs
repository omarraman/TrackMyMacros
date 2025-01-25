using AutoMapper;
using TrackMyMacros.Dtos.ExerciseDaySet;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

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
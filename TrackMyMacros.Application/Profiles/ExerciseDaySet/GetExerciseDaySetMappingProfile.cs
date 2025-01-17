using AutoMapper;
using TrackMyMacros.Dtos.ExerciseDaySet;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

namespace TrackMyMacros.Application.Profiles.ExerciseDaySet
{
    public class GetExerciseDaySetMappingProfile : Profile
    {
        public GetExerciseDaySetMappingProfile()
        {
            CreateMap<TrackMyMacros.Domain.Aggregates.Mesocycle.ExerciseDaySet, GetExerciseDaySetDto>();
        }
    }
}
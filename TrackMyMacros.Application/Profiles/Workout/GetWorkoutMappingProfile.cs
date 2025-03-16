using AutoMapper;
using TrackMyMacros.Dtos.Workout;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

namespace TrackMyMacros.Application.Profiles.Workout
{
    public class GetWorkoutMappingProfile : Profile
    {
        public GetWorkoutMappingProfile()
        {
            CreateMap<TrackMyMacros.Domain.Aggregates.Mesocycle.Workout, GetWorkoutDto>()
                .ForMember(m => m.DayOfWeek, 
                opt => opt.MapFrom(src => (int)src.DayOfWeek.Value()));
        }
    }
}
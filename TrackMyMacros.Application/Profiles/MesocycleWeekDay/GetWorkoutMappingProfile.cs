using AutoMapper;
using TrackMyMacros.Dtos.MesocycleWeekDay;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

namespace TrackMyMacros.Application.Profiles.MesocycleWeekDay
{
    public class GetWorkoutMappingProfile : Profile
    {
        public GetWorkoutMappingProfile()
        {
            CreateMap<TrackMyMacros.Domain.Aggregates.Mesocycle.Workout, GetWorkoutDto>().ForMember(m => m.DayOfWeek, 
                opt => opt.MapFrom(src => (int)src.DayOfWeek.Value()));
        }
    }
}
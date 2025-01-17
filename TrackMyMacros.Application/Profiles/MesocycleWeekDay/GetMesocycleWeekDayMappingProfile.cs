using AutoMapper;
using TrackMyMacros.Dtos.MesocycleWeekDay;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

namespace TrackMyMacros.Application.Profiles.MesocycleWeekDay
{
    public class GetMesocycleWeekDayMappingProfile : Profile
    {
        public GetMesocycleWeekDayMappingProfile()
        {
            CreateMap<TrackMyMacros.Domain.Aggregates.Mesocycle.MesocycleWeekDay, GetMesocycleWeekDayDto>().ForMember(m => m.DayOfWeek, 
                opt => opt.MapFrom(src => (int)src.DayOfWeek.Value()));
        }
    }
}
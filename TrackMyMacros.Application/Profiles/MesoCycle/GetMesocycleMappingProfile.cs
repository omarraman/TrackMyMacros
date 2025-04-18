using AutoMapper;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

namespace TrackMyMacros.Application.Profiles.Mesocycle
{
    public class GetMesocycleMappingProfile : Profile
    {
        public GetMesocycleMappingProfile()
        {
            CreateMap<TrackMyMacros.Domain.Aggregates.Mesocycle.Mesocycle, GetMesocycleDto>()
                .ForMember(m=>m.CurrentDayOfWeek,
                    opt => opt.MapFrom(src => (int)src.CurrentDayOfWeek.Value()));
        }
    }
}
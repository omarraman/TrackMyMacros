using AutoMapper;
using TrackMyMacros.Dtos.MesocycleWeek;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

namespace TrackMyMacros.Application.Profiles.MesocycleWeek
{
    public class GetMesocycleWeekMappingProfile : Profile
    {
        public GetMesocycleWeekMappingProfile()
        {
            CreateMap<TrackMyMacros.Domain.Aggregates.Mesocycle.MesocycleWeek, GetMesocycleWeekDto>();
        }
    }
}
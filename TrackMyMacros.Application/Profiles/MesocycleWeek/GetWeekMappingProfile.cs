using AutoMapper;
using TrackMyMacros.Dtos.MesocycleWeek;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

namespace TrackMyMacros.Application.Profiles.MesocycleWeek
{
    public class GetWeekMappingProfile : Profile
    {
        public GetWeekMappingProfile()
        {
            CreateMap<TrackMyMacros.Domain.Aggregates.Mesocycle.Week, GetWeekDto>();
        }
    }
}
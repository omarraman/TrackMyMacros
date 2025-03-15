using AutoMapper;
using TrackMyMacros.Domain.Aggregates.Mesocycle;
using TrackMyMacros.Dtos.Week;

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
using AutoMapper;
using TrackMyMacros.Dtos.Week;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

namespace TrackMyMacros.Application.Profiles.Week
{
    public class GetWeekMappingProfile : Profile
    {
        public GetWeekMappingProfile()
        {
            CreateMap<TrackMyMacros.Domain.Aggregates.Mesocycle.Week, GetWeekDto>();
        }
    }
}
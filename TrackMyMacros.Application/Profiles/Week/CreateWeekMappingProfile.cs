using AutoMapper;
using TrackMyMacros.Dtos.Week;
using TrackMyMacros.Domain.Aggregates.Mesocycle;
using TrackMyMacros.Application.Features.Week.Commands.Create;
using Week;

namespace TrackMyMacros.Application.Profiles.Week
{
    public class CreateWeekMappingProfile : Profile
    {
        public CreateWeekMappingProfile()
        {
            CreateMap<CreateWeekDto, CreateWeekCommand>();
            CreateMap<CreateWeekCommand, Domain.Aggregates.Mesocycle.Week>();
        }
    }
}
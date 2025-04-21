using AutoMapper;
using TrackMyMacros.Dtos.Set;
using TrackMyMacros.Domain.Aggregates.Mesocycle;
using TrackMyMacros.Application.Features.Set.Commands.Create;

namespace TrackMyMacros.Application.Profiles.Set
{
    public class CreateSetMappingProfile : Profile
    {
        public CreateSetMappingProfile()
        {
            CreateMap<CreateSetDto, CreateSetCommand>();
            CreateMap<CreateSetCommand, Domain.Aggregates.Mesocycle.Set>();
        }
    }
}
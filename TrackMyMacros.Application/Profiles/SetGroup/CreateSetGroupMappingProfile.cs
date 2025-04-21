using AutoMapper;
using TrackMyMacros.Dtos.SetGroup;
using TrackMyMacros.Domain.Aggregates.Mesocycle;
using TrackMyMacros.Application.Features.SetGroup.Commands.Create;

namespace TrackMyMacros.Application.Profiles.SetGroup
{
    public class CreateSetGroupMappingProfile : Profile
    {
        public CreateSetGroupMappingProfile()
        {
            CreateMap<CreateSetGroupDto, CreateSetGroupCommand>();
            CreateMap<CreateSetGroupCommand, Domain.Aggregates.Mesocycle.SetGroup>();
        }
    }
}
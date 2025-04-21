using AutoMapper;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.Domain.Aggregates.Mesocycle;
using TrackMyMacros.Application.Features.MesoCycle.Commands.Create;

namespace TrackMyMacros.Application.Profiles.Mesocycle
{
    public class CreateMesocycleMappingProfile : Profile
    {
        public CreateMesocycleMappingProfile()
        {
            CreateMap<CreateMesocycleDto, CreateMesocycleCommand>();
            CreateMap<CreateMesocycleCommand, Domain.Aggregates.Mesocycle.Mesocycle>();
        }
    }
}
using AutoMapper;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.App4.ViewModels;

namespace TrackMyMacros.App4.Profiles.Mesocycle
{
    public class GetMesocycleMappingProfile : Profile
    {
        public GetMesocycleMappingProfile()
        {
            CreateMap<GetMesocycleDto, GetMesocycleViewModel>();
        }
    }
}
using AutoMapper;
using TrackMyMacros.App4.ViewModels.Exercise;
using TrackMyMacros.Dtos.Exercise;

namespace TrackMyMacros.App4.Profiles.Exercise{
    public class GetExerciseMappingProfile : Profile
    {
        public GetExerciseMappingProfile()
        {
            CreateMap<GetExerciseDto, GetExerciseViewModel>();
        }
    }
}
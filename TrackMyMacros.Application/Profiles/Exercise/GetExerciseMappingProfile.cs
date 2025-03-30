using AutoMapper;
using TrackMyMacros.Dtos.Exercise;

namespace TrackMyMacros.Application.Profiles.Exercise{
    public class GetExerciseMappingProfile : Profile
    {
        public GetExerciseMappingProfile()
        {
            CreateMap<TrackMyMacros.Domain.Aggregates.Exercise.Exercise, GetExerciseDto>();
        }
    }
}
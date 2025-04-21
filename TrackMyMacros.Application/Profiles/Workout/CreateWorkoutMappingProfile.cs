using AutoMapper;
using TrackMyMacros.Dtos.Workout;
using TrackMyMacros.Domain.Aggregates.Mesocycle;
using TrackMyMacros.Application.Features.Workout.Commands.Create;
using Workout;

namespace TrackMyMacros.Application.Profiles.Workout
{
    public class CreateWorkoutMappingProfile : Profile
    {
        public CreateWorkoutMappingProfile()
        {
            CreateMap<CreateWorkoutDto, CreateWorkoutCommand>();
            CreateMap<CreateWorkoutCommand, Domain.Aggregates.Mesocycle.Workout>();
        }
    }
}
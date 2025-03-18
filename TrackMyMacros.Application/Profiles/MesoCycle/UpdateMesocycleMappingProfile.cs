using AutoMapper;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.Domain.Aggregates.Mesocycle;
using TrackMyMacros.Application.Features.Mesocycle.Commands.Update;
using TrackMyMacros.Application.Features.Set.Commands.Update;
using TrackMyMacros.Application.Features.SetGroup.Commands.Update;
using TrackMyMacros.Application.Features.Week.Commands.Update;
using TrackMyMacros.Application.Features.Workout.Commands.Update;
using TrackMyMacros.Dtos.Set;
using TrackMyMacros.Dtos.SetGroup;
using TrackMyMacros.Dtos.Week;
using TrackMyMacros.Dtos.Workout;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Profiles.Mesocycle
{
    public class UpdateMesocycleMappingProfile : Profile
    {
        public UpdateMesocycleMappingProfile()
        {
            CreateMap<UpdateMesocycleDto, UpdateMesocycleCommand>()
                .ForMember(dest => dest.Weeks,
                    opt => opt.MapFrom(src => src.Weeks));
            CreateMap<UpdateWeekDto, UpdateWeekCommand>().ForMember(dest => dest.Workouts,
                opt => opt.MapFrom(src => src.Workouts));
            CreateMap<UpdateWorkoutDto, UpdateWorkoutCommand>().ForMember(m => m.DayOfWeek,
                opt => opt.MapFrom(src =>
                    new MyDayOfWeek(src.DayOfWeek)));
            CreateMap<UpdateSetGroupDto, UpdateSetGroupCommand>();
            CreateMap<UpdateSetGroupCommand, Domain.Aggregates.Mesocycle.SetGroup>();
            CreateMap<UpdateSetDto, UpdateSetCommand>();
            CreateMap<UpdateMesocycleCommand, Domain.Aggregates.Mesocycle.Mesocycle>()
                .ForMember(dest => dest.Weeks,
                    opt => opt.MapFrom(src => src.Weeks));
            CreateMap<UpdateWeekCommand, Domain.Aggregates.Mesocycle.Week>()
                .ForMember(dest => dest.Workouts,
                    opt => opt.MapFrom(src => src.Workouts));
            CreateMap<UpdateWorkoutCommand, Domain.Aggregates.Mesocycle.Workout>()
                .ForMember(m => m.DayOfWeek,
                    opt => opt.MapFrom(src => src.DayOfWeek.Value()));
            CreateMap<UpdateSetCommand, Domain.Aggregates.Mesocycle.Set>()
                .ForMember(m => m.Reps, opt => opt.MapFrom(src => src.Reps))
                .ForMember(m => m.Weight, opt => opt.MapFrom(src => src.Weight));
        }
    }
}
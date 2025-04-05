using AutoMapper;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModels.Mesocycle;
using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.App4.ViewModels.SetGroup;
using TrackMyMacros.App4.ViewModels.Week;
using TrackMyMacros.App4.ViewModels.Workout;
using TrackMyMacros.Dtos.Set;
using TrackMyMacros.Dtos.SetGroup;
using Week;
using Workout;

namespace TrackMyMacros.App4.Profiles.Mesocycle
{
    public class CreateMesocycleMappingProfile : Profile
    {
        public CreateMesocycleMappingProfile()
        {
            CreateMap<CreateMesocycleViewModel, CreateMesocycleDto>().ForMember(m=>m.CurrentDayOfWeek, 
                opt => opt.MapFrom(src => src.CurrentDayOfWeek.Value()));
            CreateMap<CreateWeekViewModel, CreateWeekDto>();
            CreateMap<CreateWorkoutViewModel, CreateWorkoutDto>().ForMember(m=>m.DayOfWeek,
                opt => opt.MapFrom(src => src.DayOfWeek.Value()));
            CreateMap<CreateSetViewModel, CreateSetDto>();
            CreateMap<CreateSetGroupViewModel, CreateSetGroupDto>();
            
            
        }
    }
}
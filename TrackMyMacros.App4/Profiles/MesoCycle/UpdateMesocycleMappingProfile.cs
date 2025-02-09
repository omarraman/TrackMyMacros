using AutoMapper;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.App4.ViewModels.ExerciseDaySet;
using TrackMyMacros.App4.ViewModels.Mesocycle;
using TrackMyMacros.App4.ViewModels.MesocycleWeek;
using TrackMyMacros.App4.ViewModels.MesocycleWeekDay;
using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.App4.ViewModels.Week;
using TrackMyMacros.App4.ViewModels.Workout;
using TrackMyMacros.Dtos.Set;
using TrackMyMacros.Dtos.Week;
using TrackMyMacros.Dtos.Workout;

namespace TrackMyMacros.App4.Profiles.Mesocycle
{
    public class UpdateMesocycleMappingProfile : Profile
    {
        public UpdateMesocycleMappingProfile()
        {
            CreateMap<UpdateMesocycleViewModel, UpdateMesocycleDto>();
            
            //needed in workout razor
            CreateMap<GetMesocycleViewModel, UpdateMesocycleViewModel>().ForMember(
                m=>m.CurrentDayOfWeek, opt=>opt.MapFrom(src=>src.CurrentDayOfWeek.Value()));;
            CreateMap<GetWeekViewModel, UpdateWeekViewModel>();
            CreateMap<GetWorkoutViewModel, UpdateWorkoutViewModel>();
            CreateMap<GetSetViewModel, UpdateSetViewModel>();
            
            
            CreateMap<UpdateMesocycleViewModel, UpdateMesocycleDto>().ForMember(
                m=>m.CurrentDayOfWeek, opt=>opt.MapFrom(src=>src.CurrentDayOfWeek.Value()));
            
            CreateMap<UpdateWeekViewModel, UpdateWeekDto>();
            CreateMap<UpdateWorkoutViewModel, UpdateWorkoutDto>()
                .ForMember(dest => dest.DayOfWeek, 
                    opt => opt.MapFrom(src 
                        => src.DayOfWeek.Value()));
            CreateMap<UpdateSetViewModel, UpdateSetDto>();
            
            
        }
    }
}
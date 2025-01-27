using AutoMapper;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModels.ExerciseDaySet;
using TrackMyMacros.App4.ViewModels.Mesocycle;
using TrackMyMacros.App4.ViewModels.MesocycleWeek;
using TrackMyMacros.App4.ViewModels.MesocycleWeekDay;
using TrackMyMacros.Dtos.ExerciseDaySet;
using TrackMyMacros.Dtos.MesocycleWeek;
using TrackMyMacros.Dtos.MesocycleWeekDay;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.Profiles.Mesocycle
{
    public class GetMesocycleMappingProfile : Profile
    {
        public GetMesocycleMappingProfile()
        {
            CreateMap<GetMesocycleDto, GetMesocycleViewModel>();
            CreateMap<GetWeekDto, GetWeekViewModel>();
            CreateMap<GetWorkoutDto, GetWorkoutViewModel>().ForMember(m=>m.DayOfWeek,
                opt=>opt.MapFrom(src=>MyDayOfWeek.ConvertFromInt(src.DayOfWeek)));
            CreateMap<GetSetDto, GetSetViewModel>();
        }
    }
}
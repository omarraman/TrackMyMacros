using AutoMapper;
using TrackMyMacros.App4.ViewModels.Mesocycle;
using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.App4.ViewModels.SetGroup;
using TrackMyMacros.App4.ViewModels.Week;
using TrackMyMacros.App4.ViewModels.Workout;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.Dtos.Set;
using TrackMyMacros.Dtos.SetGroup;
using TrackMyMacros.Dtos.Week;
using TrackMyMacros.Dtos.Workout;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.Profiles.Mesocycle
{
    public class GetMesocycleMappingProfile : Profile
    {
        public GetMesocycleMappingProfile()
        {
            CreateMap<GetMesocycleDto, GetMesocycleViewModel>().ForMember(m=>m.CurrentDayOfWeek,
                opt=>opt.MapFrom(src=>MyDayOfWeek.ConvertFromInt(src.CurrentDayOfWeek)));
            CreateMap<GetWeekDto, GetWeekViewModel>();
            CreateMap<GetSetGroupDto, GetSetGroupViewModel>();
            CreateMap<GetWorkoutDto, GetWorkoutViewModel>().ForMember(m=>m.DayOfWeek,
                opt=>opt.MapFrom(src=>MyDayOfWeek.ConvertFromInt(src.DayOfWeek)));
            CreateMap<GetSetDto, GetSetViewModel>();
        }
    }
}
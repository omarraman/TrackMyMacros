using TrackMyMacros.App4.ViewModels.MesocycleWeekDay;

namespace TrackMyMacros.App4.ViewModels.MesocycleWeek
{
    public class GetMesocycleWeekViewModel
    {
        public int WeekIndex { get; init; }
        public List<GetMesocycleWeekDayViewModel> MesocycleWeekDays { get; init; }
    }
}
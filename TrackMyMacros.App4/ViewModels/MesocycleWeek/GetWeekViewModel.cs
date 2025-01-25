using TrackMyMacros.App4.ViewModels.MesocycleWeekDay;

namespace TrackMyMacros.App4.ViewModels.MesocycleWeek
{
    public class GetWeekViewModel
    {
        public int WeekIndex { get; init; }
        public List<GetWorkoutViewModel> Workouts { get; init; }
    }
}
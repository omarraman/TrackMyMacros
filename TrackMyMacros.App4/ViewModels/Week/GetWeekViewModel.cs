
using TrackMyMacros.App4.ViewModels.Workout;

namespace TrackMyMacros.App4.ViewModels.Week
{
    public class GetWeekViewModel
    {
        public int WeekIndex { get; init; }
        public List<GetWorkoutViewModel> Workouts { get; init; }
    }
}
using TrackMyMacros.App4.ViewModels.Workout;

namespace TrackMyMacros.App4.ViewModels.Week
{
    public class UpdateWeekViewModel
    {
        public int WeekIndex { get; init; }
        public List<UpdateWorkoutViewModel> Workouts { get; init; }
    }
}
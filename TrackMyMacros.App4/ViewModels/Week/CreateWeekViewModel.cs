using TrackMyMacros.App4.ViewModels.Workout;

namespace TrackMyMacros.App4.ViewModels.Week
{
    public class CreateWeekViewModel
    {
        public int WeekIndex { get; init; }
        public List<CreateWorkoutViewModel> Workouts { get; init; }
    }
}
using TrackMyMacros.App4.ViewModels.Week;
using TrackMyMacros.App4.ViewModels.Workout;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.ViewModels.Mesocycle
{
    public class GetMesocycleViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<GetWeekViewModel> Weeks { get; set; }
        public int CurrentWeekIndex { get; set; }
        public MyDayOfWeek CurrentDayOfWeek { get; set; }
        public int  TotalWeeks { get; set; }
        public bool Complete { get; set; }
        public GetWorkoutViewModel GetCurrentWorkout()
        {
            return Weeks.Single(week => week.WeekIndex == CurrentWeekIndex).Workouts
                .Single(workout => workout.DayOfWeek == CurrentDayOfWeek);
        }
    }
}
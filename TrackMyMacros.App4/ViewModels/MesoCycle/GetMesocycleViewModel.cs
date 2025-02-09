using TrackMyMacros.App4.ViewModels.MesocycleWeek;
using TrackMyMacros.App4.ViewModels.MesocycleWeekDay;
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

        public GetWorkoutViewModel GetCurrentWorkout()
        {
            return Weeks.Single(week => week.WeekIndex == CurrentWeekIndex).Workouts
                .Single(workout => workout.DayOfWeek == CurrentDayOfWeek);
        }
    }
}
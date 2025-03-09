using TrackMyMacros.App4.ViewModels.ExerciseDaySet;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.ViewModels.MesocycleWeekDay
{
    public class GetWorkoutViewModel
    {
        public MyDayOfWeek DayOfWeek { get; init; }
        public string DayOfWeekName => DayOfWeek.StringEquivalent();
        public List<GetSetViewModel> Sets { get; init; }
        public bool Complete { get; private set; }
    }
}
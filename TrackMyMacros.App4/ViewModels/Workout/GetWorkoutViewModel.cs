using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.ViewModels.Workout
{
    public class GetWorkoutViewModel
    {
        public MyDayOfWeek DayOfWeek { get; init; }
        public string DayOfWeekName => DayOfWeek.StringEquivalent();
        public List<GetSetViewModel> Sets { get; init; }
        public bool Complete { get; init; }
        public int MyProperty { get; set; }

    }
}
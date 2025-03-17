using TrackMyMacros.App4.ViewModels.SetGroup;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.ViewModels.Workout
{
    public class GetWorkoutViewModel
    {
        public MyDayOfWeek DayOfWeek { get; init; }
        public string DayOfWeekName => DayOfWeek.StringEquivalent();
        public List<GetSetGroupViewModel> SetGroups { get; init; }
        public bool Complete { get; init; }
    }
}
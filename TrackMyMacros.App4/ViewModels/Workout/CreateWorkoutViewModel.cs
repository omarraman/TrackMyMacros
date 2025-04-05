using TrackMyMacros.App4.ViewModels.SetGroup;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.ViewModels.Workout
{
    public class CreateWorkoutViewModel
    {
        public MyDayOfWeek DayOfWeek { get; init; }
        public List<CreateSetGroupViewModel> SetGroups { get; init; }
    }
}
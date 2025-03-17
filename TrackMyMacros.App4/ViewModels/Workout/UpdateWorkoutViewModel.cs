using TrackMyMacros.App4.ViewModels.SetGroup;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.ViewModels.Workout
{
    public class UpdateWorkoutViewModel
    {
        public MyDayOfWeek DayOfWeek { get; init; }
        public List<UpdateSetGroupViewModel> SetGroups { get; init; }
    }
}
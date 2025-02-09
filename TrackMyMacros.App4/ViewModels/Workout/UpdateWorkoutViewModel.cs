using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.ViewModels.Workout
{
    public class UpdateWorkoutViewModel
    {
        public MyDayOfWeek DayOfWeek { get; init; }
        public List<UpdateSetViewModel> Sets { get; init; }
    }
}
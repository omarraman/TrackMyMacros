using TrackMyMacros.App4.ViewModels.ExerciseDaySet;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.ViewModels.MesocycleWeekDay
{
    public class GetMesocycleWeekDayViewModel
    {
        public MyDayOfWeek DayOfWeek { get; init; }
        public List<GetExerciseDaySetViewModel> ExerciseDaySets { get; init; }
        public bool Complete { get; private set; }
    }
}
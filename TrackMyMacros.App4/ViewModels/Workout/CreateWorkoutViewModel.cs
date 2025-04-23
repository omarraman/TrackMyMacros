using TrackMyMacros.App4.ViewModels.SetGroup;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.ViewModels.Workout
{
    public class CreateWorkoutViewModel
    {
        public MyDayOfWeek DayOfWeek { get; set; }
        public List<CreateSetGroupViewModel> SetGroups { get; init; }

        public List<CreateSetGroupViewModel> SetGroupsInPriorityOrder
        {
            get
            {
                var setGroups = SetGroups.OrderBy(x => x.Priority).ToList();
                return setGroups;
            }
        }
    }
}
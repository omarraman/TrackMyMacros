using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TrackMyMacros.App4.ViewModels.Exercise;
using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.App4.ViewModels.SetGroup;
using TrackMyMacros.App4.ViewModels.Week;
using TrackMyMacros.App4.ViewModels.Workout;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.Components;

public partial class AddWeekComponent : ComponentBase
{
    //[Parameter] public EventCallback OnWorkoutUpdated { get; set; }
    [Parameter] public CreateWeekViewModel Week { get; set; }
    [Parameter] public IReadOnlyList<GetExerciseViewModel> Exercises { get; set; }

    private void OnAddWorkout(MouseEventArgs obj)
    {
        Week.Workouts.Add(
            new CreateWorkoutViewModel
            {
                DayOfWeek = MyDayOfWeek.Monday(),
                SetGroups = new List<CreateSetGroupViewModel>()
            }
        );
    }
}
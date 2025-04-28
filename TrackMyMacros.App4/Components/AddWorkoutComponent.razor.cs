using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TrackMyMacros.App4.ViewModels.Exercise;
using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.App4.ViewModels.SetGroup;
using TrackMyMacros.App4.ViewModels.Workout;
using TrackMyMacros.Domain.Aggregates.Exercise;
using TrackMyMacros.SharedKernel;
using Workout;

namespace TrackMyMacros.App4.Components;

public partial class AddWorkoutComponent
{
    /*[Parameter] public EventCallback OnWorkoutUpdated { get; set; }*/
    [Parameter] public CreateWorkoutViewModel Workout { get; set; }

    public MyDayOfWeek DayOfWeek { get; set; }

    public List<MyDayOfWeek> Days { get; set; } = new()
    {
        MyDayOfWeek.Monday(),
        MyDayOfWeek.Tuesday(),
        MyDayOfWeek.Wednesday(),
        MyDayOfWeek.Thursday(),
        MyDayOfWeek.Friday(),
        MyDayOfWeek.Saturday(),
        MyDayOfWeek.Sunday()
    };

    protected override async Task OnInitializedAsync()
    {
        //AddSet();
        //Workout = new CreateWorkoutViewModel
        //{
        //    DayOfWeek = MyDayOfWeek.Monday(),
        //    SetGroups = new List<CreateSetGroupViewModel>()
        //};


        /*var setGroup = new CreateSetGroupViewModel
        {
            Sets = new List<CreateSetViewModel>
            {
                new()
                {
                    Weight = 0,
                    Reps = 0,
                }
            },
            ExerciseId = Exercise.Flyes().Id,
            Priority = CurrentHighestPriority++
        };

        SetGroups.Add(setGroup);
        Workout.SetGroups.Add(setGroup);*/
    }

    public List<CreateSetGroupViewModel> SetGroups { get; set; } = new();

    [Parameter] public IReadOnlyList<GetExerciseViewModel> Exercises { get; set; }


    //public CreateWorkoutViewModel CreateWorkoutViewModel { get; set; } = new();

    /*public async Task OnSave(MouseEventArgs obj)
    {
        await OnWorkoutUpdated.InvokeAsync();
    }*/

    public int CurrentHighestPriority { get; set; } = 1;

    public void OnAddSet(MouseEventArgs obj)
    {
        AddSet();
    }

    public void OnSetGroupMovedUp(int priority)
    {
        var itemToMoveDown =Workout.SetGroups.Single(m=> m.Priority == priority-1);
        var itemToMoveUp =Workout.SetGroups.Single(m => m.Priority == priority);
        itemToMoveUp.Priority = priority-1;
        itemToMoveDown.Priority = priority;
    }
    
    public void OnSetGroupMovedDown(int priority)
    {
        var itemToMoveDown =Workout.SetGroups.Single(m=> m.Priority == priority);
        var itemToMoveUp =Workout.SetGroups.Single(m => m.Priority == priority+1);
        itemToMoveUp.Priority = priority;
        itemToMoveDown.Priority = priority+1;
    }
    private void AddSet()
    {
        var setGroup = new CreateSetGroupViewModel
        {
            Sets = new List<CreateSetViewModel>
            {
                new()
                {
                    TargetWeight = 5,
                    TargetReps = 10,
                }
            },
            ExerciseId = Exercise.Flyes().Id,
            Priority = CurrentHighestPriority++
        };

        SetGroups.Add(setGroup);
        Workout.SetGroups.Add(setGroup);
    }
}
using AutoMapper;
using Microsoft.AspNetCore.Components;
using Radzen;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels.Mesocycle;
using TrackMyMacros.App4.ViewModels.Workout;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.Components;

public partial class ViewMesocycleComponent
{
    [Parameter] public GetMesocycleViewModel Mesocycle { get; set; }
    [Inject] public IGenericDataService _dataService { get; set; }

    [Inject] public IMapper _mapper { get; set; }
    public Maybe<GetWorkoutViewModel> WorkoutInFocus { get; set; }

    public bool CurrentWorkoutComplete { get; set; } = false;

    object _treeNode;

    protected override void OnInitialized()
    {
        WorkoutInFocus= Mesocycle.Weeks.FirstOrDefault()?.Workouts.FirstOrDefault();
    }


    void OnChangeTreeNode(TreeEventArgs args)
    {
        if (args.Value is GetWorkoutViewModel workout)
        {
            WorkoutInFocus = workout;
        }
    }

}
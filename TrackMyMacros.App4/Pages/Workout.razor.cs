using System.Diagnostics;
using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels.Mesocycle;
using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.App4.ViewModels.Workout;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.Pages;

public partial class Workout
{
    private GetMesocycleViewModel _meso;
    [Inject] public IGenericDataService _dataService { get; set; }

    [Inject] public IMapper _mapper { get; set; }
    public Maybe<GetWorkoutViewModel> WorkoutInFocus { get; set; }

    public bool CurrentWorkoutComplete { get; set; } = false;

    object _treeNode;
    protected override async Task OnInitializedAsync()
    {
        await RefreshMeso();

        await base.OnInitializedAsync();
    }

    private async Task RefreshMeso()
    {
        var mesos =await _dataService.GetList<GetMesocycleViewModel,GetMesocycleDto>(Endpoint.Mesocycle);
        _meso = mesos.First(m=>m.Complete == false);
        // _meso = await _dataService.Get<GetMesocycleViewModel, GetMesocycleDto>(Endpoint.Mesocycle,
        //     new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"));
        WorkoutInFocus = _meso.GetCurrentWorkout();
    }

    private async Task OnSave(MouseEventArgs obj)
    {
        await Save();
    }
    
    private void AddSet(GetSetViewModel set)
    {
        WorkoutInFocus.Value.Sets.Add(set.AddFollowingSet());
    }

    private async Task Save()
    {
        var updateViewModel = _mapper.Map<UpdateMesocycleViewModel>(_meso);
        updateViewModel.CurrentWorkoutComplete = CurrentWorkoutComplete;
        await _dataService.Put<UpdateMesocycleViewModel, UpdateMesocycleDto>(Endpoint.Mesocycle, updateViewModel);
        await RefreshMeso();
    }

    private void OnComplete(MouseEventArgs obj)
    {
        CurrentWorkoutComplete = true;
    }

    void OnChangeTreeNode(TreeEventArgs args)
    {
        if (args.Value is GetWorkoutViewModel workout)
        {
            WorkoutInFocus = workout;
        }
    }

}
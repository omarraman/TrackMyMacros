using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.Services.DailyLimitsDataService;
using TrackMyMacros.App4.ViewModels.Mesocycle;
using TrackMyMacros.App4.ViewModels.MesocycleWeekDay;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App4.Pages;

public partial class Workout
{
    private GetMesocycleViewModel _meso;
    [Inject] public IGenericDataService _dataService { get; set; }

    [Inject] public IMapper _mapper { get; set; }
    public Maybe<GetWorkoutViewModel> CurrentWorkout { get; set; }

    public bool CurrentWorkoutComplete { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        _meso = await _dataService.Get<GetMesocycleViewModel, GetMesocycleDto>(Endpoint.Mesocycle,
            new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"));
        CurrentWorkout = _meso.GetCurrentWorkout();

        await base.OnInitializedAsync();
    }

    private async Task OnSave(MouseEventArgs obj)
    {
        await Save();
    }

    private async Task Save()
    {
        var updateViewModel = _mapper.Map<UpdateMesocycleViewModel>(_meso);
        updateViewModel.CurrentWorkoutComplete = CurrentWorkoutComplete;
        await _dataService.Put<UpdateMesocycleViewModel, UpdateMesocycleDto>(Endpoint.Mesocycle, updateViewModel);
    }

    private async Task OnComplete(MouseEventArgs obj)
    {
        CurrentWorkoutComplete = true;
        await Save();
    }

}
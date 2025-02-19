using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.Services.DailyLimitsDataService;
using TrackMyMacros.App4.ViewModels.Mesocycle;
using TrackMyMacros.App4.ViewModels.MesocycleWeekDay;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;

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
        await RefreshMeso();

        await base.OnInitializedAsync();
    }

    private async Task RefreshMeso()
    {
        _meso = await _dataService.Get<GetMesocycleViewModel, GetMesocycleDto>(Endpoint.Mesocycle,
            new Guid("e1c5d850-e750-4742-9abf-9691f97c5fbd"));
        CurrentWorkout = _meso.GetCurrentWorkout();
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
        await RefreshMeso();
    }

    private void OnComplete(MouseEventArgs obj)
    {
        CurrentWorkoutComplete = true;
        // await Save();
        // StateHasChanged();
    }

}
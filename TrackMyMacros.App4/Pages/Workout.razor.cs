using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.Services.DailyLimitsDataService;
using TrackMyMacros.App4.ViewModels.Mesocycle;
using TrackMyMacros.App4.ViewModels.MesocycleWeekDay;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App4.Pages;

public partial class Workout
{
    [Inject] public IGenericDataService _dataService { get; set; }
    public Maybe<GetWorkoutViewModel> CurrentWorkout { get; set; }


    protected override async Task OnInitializedAsync()
    {
        var meso = await _dataService.Get<GetMesocycleViewModel,GetMesocycleDto>(Endpoint.Mesocycle, new Guid("1d34e9b2-27ad-442f-9ab1-24964f2a5ff4"));
        CurrentWorkout = meso.GetCurrentWorkout();

        await base.OnInitializedAsync();
    }
}
using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels.Exercise;
using TrackMyMacros.App4.ViewModels.Mesocycle;
using TrackMyMacros.App4.ViewModels.Week;
using TrackMyMacros.App4.ViewModels.Workout;
using TrackMyMacros.Domain.Aggregates.Exercise;
using TrackMyMacros.Dtos.Exercise;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4;

public partial class AddMesocycleTemplate : ComponentBase
{
    [Inject] public NavigationManager NavigationManager { get; set; } = default!;


    [Inject] public IGenericDataService DataService { get; set; } = default!;

    public CreateMesocycleViewModel MesocycleViewModel { get; set; } = new();

    public IReadOnlyList<GetExerciseViewModel> Exercises { get; set; }
    public string Name { get; set; }
    public int NumberOfWeeks { get; set; } = 5;

    private bool _isLoading;

    public bool HasValidationError { get; set; } = false;

    public string ErrorMessage { get; set; }

    protected override async Task OnInitializedAsync()
    {
        _isLoading = true;

        MesocycleViewModel.Weeks = new List<CreateWeekViewModel>();
        MesocycleViewModel.Weeks.Add(
            new CreateWeekViewModel
            {
                WeekIndex = 1,
                Workouts = new List<CreateWorkoutViewModel>()
            });

        try
        {
            Exercises = await DataService.GetList<GetExerciseViewModel, GetExerciseDto>(Endpoint.Exercise);
            // Perform any necessary initialization logic here
            // For example, loading data or setting up state
        }
        finally
        {
            _isLoading = false;
        }
    }


    public async Task OnSaveMesocycleTemplate()
    {
        try
        {
            ErrorMessage = string.Empty;
            await DataService.Post<CreateMesocycleViewModel, CreateMesocycleDto>(MesocycleViewModel,
                Endpoint.Mesocycle.Value);
        }
        catch (Exception e)
        {
            ErrorMessage= e.Message;
        }
    }

    /*
    public void OnAddWeek()
    {
        MesocycleViewModel.Weeks.Add(
            new CreateWeekViewModel
            {
                WeekIndex = 1,
                Workouts = new List<CreateWorkoutViewModel>()
            });
    }
    */

    /*
    private async Task OnSave()
    {
        if (string.IsNullOrWhiteSpace(_name))
        {
            return;
        }

        var mesocycle = new CreateMesocycleViewModel
        {
            Name = _name,
            Description = _description,
            TotalWeeks = 4,
            Complete = false,
            CurrentWeekIndex = 1,
            CurrentDayOfWeek = MyDayOfWeek.Monday()
        };

        await MesocycleService.CreateMesocycle(mesocycle);
        StateContainer.SetState(State.Mesocycles);
        NavigationManager.NavigateTo("/mesocycles");
    }*/
}
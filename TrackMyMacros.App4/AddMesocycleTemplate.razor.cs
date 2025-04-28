using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels.Exercise;
using TrackMyMacros.App4.ViewModels.Mesocycle;
using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.App4.ViewModels.SetGroup;
using TrackMyMacros.App4.ViewModels.Week;
using TrackMyMacros.App4.ViewModels.Workout;
using TrackMyMacros.Domain.Aggregates.Exercise;
using TrackMyMacros.Dtos.Exercise;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4;

public partial class AddMesocycleTemplate : ComponentBase
{
    
    [Parameter]
    public Guid? Id { get; set; }
    
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

        if (!Id.HasValue)
        {
            EditMode = false;
            CreateMesoTemplate();
        }
        else
        {
            EditMode = true;
            var existingMeso = await DataService.Get<GetMesocycleViewModel, GetMesocycleDto>(
                Endpoint.Mesocycle, Id.Value);

            CreateMesoTemplateFromExisting(existingMeso);
            //map this to the create mesocycle view model
        }
      

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

    private void CreateMesoTemplateFromExisting(GetMesocycleViewModel existingMeso)
    {
        MesocycleViewModel.IsTemplate = true;
        MesocycleViewModel.Name = existingMeso.Name;

        MesocycleViewModel = new CreateMesocycleViewModel
        {
            IsTemplate = true,
            Name = existingMeso.Name,
            Weeks = existingMeso.Weeks.Select(week => new CreateWeekViewModel
            {
                WeekIndex = week.WeekIndex,
                Workouts = week.Workouts.Select(workout => new CreateWorkoutViewModel
                {
                    DayOfWeek = workout.DayOfWeek,
                    SetGroups = workout.SetGroups.Select(setGroup => new CreateSetGroupViewModel
                    {
                        Priority = setGroup.Priority,
                        ExerciseId = setGroup.ExerciseId,
                        Sets = setGroup.Sets.Select(set => new CreateSetViewModel
                        {
                            TargetReps = set.TargetReps,
                            TargetWeight = set.TargetWeight
                        }).ToList()
                    }).ToList()
                }).ToList()
            }).ToList()
        };

    }
    
    
    private void CreateMesoTemplate()
    {
        MesocycleViewModel.IsTemplate = true;
        MesocycleViewModel.Weeks = new List<CreateWeekViewModel>();
        MesocycleViewModel.Weeks.Add(
            new CreateWeekViewModel
            {
                WeekIndex = 1,
                Workouts = new List<CreateWorkoutViewModel>()
            });
    }

    public bool EditMode { get; set; }


    public async Task OnSaveMesocycleTemplate()
    {
        try
        {
            if (EditMode)
            {
                //delete the existing mesocycle with the same id
                //await DataService.Delete(Endpoint.Mesocycle, Id.Value);
                //create a new one as below
            }
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
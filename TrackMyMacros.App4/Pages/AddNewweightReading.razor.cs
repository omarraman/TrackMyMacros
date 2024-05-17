using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.Dtos.WeightReading;

namespace TrackMyMacros.App4.Pages;

public partial class AddNewWeightReading
{
    [Inject] public IGenericDataService DataService { get; set; }

    public WeightReadingViewModel WeightReadingViewModel { get; set; }

    private List<string> AlertMessages { get; set; } = new();

    public async Task SaveAndClose()
    {
        await DataService.Post<WeightReadingViewModel, CreateWeightReadingDto>(WeightReadingViewModel,
            GenericDataService.Endpoints.WeightReading);
        
        InitializeViewModel();
        AlertMessages.Add("Record Added");
        StateHasChanged();
    }

    protected async override Task OnInitializedAsync()
    {
        InitializeViewModel();
    }

    private void InitializeViewModel()
    {
        WeightReadingViewModel = new WeightReadingViewModel
        {
            Date = DateTime.UtcNow,
            Weight = 71
        };
    }
    
    
}
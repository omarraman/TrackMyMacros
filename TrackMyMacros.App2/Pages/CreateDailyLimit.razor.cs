using Microsoft.AspNetCore.Components;
using TrackMyMacros.App2.Services;
using TrackMyMacros.App2.Services.DailyLimitsDataService;
using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Pages;

public partial class CreateDailyLimit
{
    [Inject] public IDailyLimitsDataService DailyLimitsDataService { get; set; }

    public List<string> AlertMessages { get; set; } = new List<string>();

    // [Inject] public IFoodDataService FoodDataService { get; set; }
    // public CreateFoodViewModel NewFood { get; set; } = new CreateFoodViewModel();

    public DailyLimitsViewModel DailyLimits { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var dailyLimitsResult = await DailyLimitsDataService.GetDailyLimits();

        if (dailyLimitsResult.IsFailure && dailyLimitsResult is NoDailyLimitRecordFoundErrorResult)
        {
            DailyLimits = new DailyLimitsViewModel
            {
                Calories = 2030,
                Carbohydrate = 250,
                Protein = 145
            };
        }
        else
        {
            DailyLimits = dailyLimitsResult.Value;
        }

        // InitializeFood();
    }

    private async Task HandleValidSubmit()
    {
        
        var result = await DailyLimitsDataService.UpdateDailyLimits(DailyLimits);
        if (result is BadArgumentErrorResult)   
        {
            AlertMessages.Add("There was an error saving. Please check your data and try again.");
            StateHasChanged();
            return;
        }

        
        AlertMessages.Add("Food Added");
        StateHasChanged();
    }

}
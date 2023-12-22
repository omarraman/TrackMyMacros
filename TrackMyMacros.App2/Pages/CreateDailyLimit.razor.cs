using System.Timers;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
using TrackMyMacros.App2.Interfaces;
using TrackMyMacros.App2.Services;
using TrackMyMacros.App2.ViewModels;
using Timer = System.Timers.Timer;

namespace TrackMyMacros.App2.Pages;

public partial class CreateDailyLimit
{
    [Inject] public IDailyLimitsDataService DailyLimitsDataService { get; set; }


    public List<string> AlertMessages { get; set; } = new List<string>();

    [Inject] public IFoodDataService FoodDataService { get; set; }
    public CreateFoodViewModel NewFood { get; set; } = new CreateFoodViewModel();

    protected async override Task OnInitializedAsync()
    {
        DailyLimits = await DailyLimitsDataService.GetDailyLimits();
        if (DailyLimits.IsFailure)
        {
            
        }
        InitializeFood();
    }

    public Result<DailyLimitsViewModel> DailyLimits { get; set; }

    private async Task HandleValidSubmit()
    {
        await FoodDataService.AddFood(NewFood);
        NewFood = new CreateFoodViewModel();
        AlertMessages.Add("Food Added");
        StateHasChanged();
    }

    private void InitializeFood()
    {
        NewFood = new CreateFoodViewModel
        {
            UomId = 1
        };
    }

}
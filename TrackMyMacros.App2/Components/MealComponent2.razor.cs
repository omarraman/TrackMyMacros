using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Radzen;
using Radzen.Blazor;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App2.Components;

public partial class MealComponent2
{
    [Inject] public NavigationManager NavigationManager { get; set; }
    [Inject] public DialogService DialogService { get; set; }
    [Parameter] public MealViewModel Meal { get; set; }
    [Parameter] public IReadOnlyList<FoodListItemViewModel> FoodList { get; set; }
    [Parameter] public EventCallback OnMealMacrosChanged { get; set; }
    [Parameter] public EventCallback OnSaveDay { get; set; }

    [Parameter] public Maybe<int> AllowedProtein { get; set; }
    [Parameter] public Maybe<int> AllowedCarbohydrate { get; set; }
    [Parameter] public Maybe<int> AllowedFat { get; set; }
    [Parameter] public MacroBasedDayViewModel ParentDayModel { get; set; }

    public MacroBasedDayViewModel ParentDayCopy { get; set; }

    [Parameter] public int MealIndex { get; set; }


    private void OnAddFood()
    {
        Meal.FoodAmounts.Add(new FoodAmountViewModel { FoodId = -1, Quantity = 10 });
        StateHasChanged();
    }

    private async Task RemoveFoodItem(FoodAmountViewModel foodAmount)
    {
        Meal.FoodAmounts.Remove(foodAmount);
        Meal.RefreshTotals();
        await OnMealMacrosChanged.InvokeAsync();
        StateHasChanged();
    }

    private async Task OnQuantitiesChanged()
    {
        Meal.RefreshTotals();
        await OnMealMacrosChanged.InvokeAsync();
        StateHasChanged();
    }

    private async Task OnSave()
    {
        await OnSaveDay.InvokeAsync();
    }
    public async Task ShowInlineDialog()
    {
        var json = JsonConvert.SerializeObject(ParentDayModel);
        ParentDayCopy = JsonConvert.DeserializeObject<MacroBasedDayViewModel>(json);
        await DialogService.OpenAsync<MoveRemainingMacros>("Move Remaining", new Dictionary<string, object>
        {
            { "Day", ParentDayCopy },
            { "IndexOfMacroDonatorMeal", MealIndex },
            { "DialogService", DialogService },
            { "OnSaveAndClose", EventCallback.Factory.Create(this, OnSaveMoveRemainingMacrosDialog) },
            { "OnClose", EventCallback.Factory.Create(this, OnCloseMoveRemainingMacrosDialog) }
        });
        // , new DialogOptions { Width = "400px" }
    }

    public void OnSaveMoveRemainingMacrosDialog()
    {
        
        for (int i = 0; i < ParentDayCopy.Meals.Count; i++)
        {
            ParentDayModel.Meals[i].AllowedProtein = ParentDayCopy.Meals[i].AllowedProtein;
            ParentDayModel.Meals[i].AllowedCarbohydrate = ParentDayCopy.Meals[i].AllowedCarbohydrate;
            ParentDayModel.Meals[i].AllowedFat = ParentDayCopy.Meals[i].AllowedFat;
        }
        
        OnMealMacrosChanged.InvokeAsync();
    }

    public void OnCloseMoveRemainingMacrosDialog()
    {
    }
}
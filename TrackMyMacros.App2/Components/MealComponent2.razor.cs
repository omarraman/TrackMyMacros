using Microsoft.AspNetCore.Components;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App2.Components;

public partial class MealComponent2
{
    [Parameter] public MealViewModel Meal { get; set; }
    [Parameter] public IReadOnlyList<FoodListItemViewModel> FoodList { get; set; }
    [Parameter] public EventCallback OnMealMacrosChanged { get; set; }

    [Parameter] public Maybe<int> AllowedProtein { get; set; }
    [Parameter] public Maybe<int> AllowedCarbohydrate { get; set; }
    [Parameter] public Maybe<int> AllowedFat { get; set; }
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
}
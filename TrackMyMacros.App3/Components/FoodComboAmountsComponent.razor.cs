using Microsoft.AspNetCore.Components;
using TrackMyMacros.App3.ViewModels;

namespace TrackMyMacros.App3.Components;

public partial class FoodComboAmountsComponent
{
    [Parameter] public MealViewModel Meal { get; set; }
    // [Parameter] public IReadOnlyList<FoodListItemViewModel> FoodList { get; set; }
    
    private void OnAddFood()
    {
        Meal.FoodAmounts.Add(new FoodAmountViewModel { FoodId = -1, Quantity = 10 });
        StateHasChanged();
    }

    private async Task RemoveFoodItem(FoodAmountViewModel foodAmount)
    {
        Meal.FoodAmounts.Remove(foodAmount);
        Meal.RefreshTotals();
        StateHasChanged();
    }

    private async Task OnQuantitiesChanged()
    {
        Meal.RefreshTotals();
        StateHasChanged();
    }
}

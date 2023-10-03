using Microsoft.AspNetCore.Components;
using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Components;

public partial class MealComponent2
{
    [Parameter] public MealViewModel Meal { get; set; }
    [Parameter] public IReadOnlyList<FoodListItemViewModel> FoodList { get; set; }

    List<MealFoodItemComponent> ComponentRefs = new List<MealFoodItemComponent>();

    MealFoodItemComponent ComponentRef
    {
        set { ComponentRefs.Add(value); }
    }

    public MealViewModel GetMealViewModel()
    {
        return new MealViewModel()
        {
            FoodAmounts = ComponentRefs.Select(x => new FoodAmountViewModel()
            {
                FoodId = x.FoodId,
                Quantity = x.Quantity
            }).ToList()
        };
    }

    private void OnAddFood()
    {
        Meal.FoodAmounts.Add(new FoodAmountViewModel { FoodId = -1, Quantity = 10 });
        StateHasChanged();
    }

    private void RemoveFoodItem(string guid)
    {
        Meal.FoodAmounts.RemoveAll(x => x.Guid == guid);
        var toRemove = ComponentRefs.Single(m => m.Guid == guid);
        ComponentRefs.Remove(toRemove);
        StateHasChanged();
    }
}
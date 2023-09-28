using Microsoft.AspNetCore.Components;
using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Components;

public partial class MealComponent
{
    [Parameter] public MealViewModel Meal { get; set; }
    [Parameter] public IReadOnlyList<FoodListItemViewModel> FoodList { get; set; }

    
}

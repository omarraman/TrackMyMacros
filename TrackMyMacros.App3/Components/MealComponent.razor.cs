using Microsoft.AspNetCore.Components;
using TrackMyMacros.App3.ViewModels;

namespace TrackMyMacros.App3.Components;

public partial class MealComponent
{
    [Parameter] public MealViewModel Meal { get; set; }
    [Parameter] public IReadOnlyList<FoodListItemViewModel> FoodList { get; set; }

    
}

using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.ViewModels;

namespace TrackMyMacros.App4.Components
{
    public partial class MealComponent
    {
        [Parameter] public MealViewModel Meal { get; set; }
        [Parameter] public IReadOnlyList<FoodListItemViewModel> FoodList { get; set; }

    
    }
}

using Microsoft.AspNetCore.Components;
using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Components;

public partial class MoveRemainingMacrosMealItem
{
    [Parameter] public MealViewModel Meal { get; set; }
    [Parameter] public MealViewModel DonorMeal { get; set; }

    [Parameter] public int MealIndex { get; set; }

    [Parameter] public bool IsDonatorMeal { get; set; }

    [Parameter] public EventCallback<int> OnBorrowProtein { get; set; }
    [Parameter] public EventCallback<int> OnGiveBackProtein { get; set; }
    
    [Parameter] public EventCallback<int> OnBorrowFat { get; set; }
    [Parameter] public EventCallback<int> OnGiveBackFat { get; set; }
    
    [Parameter] public EventCallback<int> OnBorrowCarbohydrate { get; set; }
    [Parameter] public EventCallback<int> OnGiveBackCarbohydrate { get; set; }
    
    public void OnBorrowProteinClick()
    {
        if (DonorMeal.AllowedProtein-DonorMeal.Protein < 1)
            return;
        Meal.AllowedProtein += 1;
        OnBorrowProtein.InvokeAsync(MealIndex);
    }
    
    public void OnGiveBackProteinClick()
    {
        if (Meal.AllowedProtein-Meal.Protein < 1)
            return;
        Meal.AllowedProtein -= 1;
        OnGiveBackProtein.InvokeAsync(MealIndex);
    }
    
    public void OnBorrowFatClick()
    {
        if(DonorMeal.AllowedFat-DonorMeal.Fat < 1)
            return;
        Meal.AllowedFat += 1;
        OnBorrowFat.InvokeAsync(MealIndex);
    }
    
    public void OnGiveBackFatClick()
    {
        if(Meal.AllowedFat-Meal.Fat < 1)
            return;   
        Meal.AllowedFat -= 1;
        OnGiveBackFat.InvokeAsync(MealIndex);
    }
    
    public void OnBorrowCarbohydrateClick()
    {
        if(DonorMeal.AllowedCarbohydrate-DonorMeal.Carbohydrate < 1)
            return;
        Meal.AllowedCarbohydrate += 1;
        OnBorrowCarbohydrate.InvokeAsync(MealIndex);
    }
    
    public void OnGiveBackCarbohydrateClick()
    {
        if(Meal.AllowedCarbohydrate-Meal.Carbohydrate < 1)
            return;
        Meal.AllowedCarbohydrate -= 1;
        OnGiveBackCarbohydrate.InvokeAsync(MealIndex);
    }
    protected override Task OnInitializedAsync()
    {
        
        return base.OnInitializedAsync();
    }
}
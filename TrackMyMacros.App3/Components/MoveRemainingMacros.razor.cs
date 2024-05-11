using Microsoft.AspNetCore.Components;
using Radzen;
using TrackMyMacros.App3.ViewModels;

namespace TrackMyMacros.App3.Components;

public partial class MoveRemainingMacros
{
    [Parameter] public MacroBasedDayViewModel Day { get; set; }
    
    [Parameter] public int IndexOfMacroDonatorMeal { get; set; }
    
    [Parameter] public DialogService DialogService { get; set; }
    
    [Parameter] public EventCallback OnClose { get; set; }
    [Parameter] public EventCallback OnSaveAndClose { get; set; }

    public void OnBorrowProtein(int mealIndex)
    {
        Day.Meals[IndexOfMacroDonatorMeal].AllowedProtein -= 1;
    }
    
    public void OnGiveBackProtein(int mealIndex)
    {
        Day.Meals[IndexOfMacroDonatorMeal].AllowedProtein += 1;
    }
    
    public void OnBorrowFat(int mealIndex)
    {
        Day.Meals[IndexOfMacroDonatorMeal].AllowedFat -= 1;
    }
    
    public void OnGiveBackFat(int mealIndex)
    {
        Day.Meals[IndexOfMacroDonatorMeal].AllowedFat += 1;
    }
    
    public void OnBorrowCarbohydrate(int mealIndex)
    {
        Day.Meals[IndexOfMacroDonatorMeal].AllowedCarbohydrate -= 1;
    }
    
    public void OnGiveBackCarbohydrate(int mealIndex)
    {
        Day.Meals[IndexOfMacroDonatorMeal].AllowedCarbohydrate += 1;
    }
    protected override Task OnInitializedAsync()
    {
        
        return base.OnInitializedAsync();
    }

    private void SaveAndCloseDialog()
    {
        DialogService.Close();
        OnSaveAndClose.InvokeAsync();

    }
    private void CloseDialog()
    {
        DialogService.Close();
        OnClose.InvokeAsync();
    }
}
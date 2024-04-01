using AutoMapper;
using Microsoft.AspNetCore.Components;
using Radzen;
using TrackMyMacros.App2.Services;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;
using TrackMyMacros.Dtos.FoodCombo;

namespace TrackMyMacros.App2.Components;

public partial class CreateFoodComboDialog
{
    [Parameter]
    public DialogService DialogService { get; set; }
    
    [Parameter] public MealViewModel Meal { get; set; }
    
    [Parameter]
    public EventCallback OnDialogClose { get; set; }
    
    [Inject] public IFoodComboDataService _foodComboDataService { get; set; }

    [Inject] public IMapper Mapper { get; set; }

    [Parameter]
    public string FoodComboName { get; set; }

    [Parameter] public Guid Id { get; set; }
    [Parameter] public bool EditMode { get; set; } = false;
    public async Task SaveAndClose()
    {
        if (EditMode)
        {
            await _foodComboDataService.UpdateMealCombo(Meal, FoodComboName, Id);
        }
        else
        {
            await _foodComboDataService.CreateMealCombo(Meal, FoodComboName);
        }

        await OnDialogClose.InvokeAsync();
        DialogService.Close();
    }
    
    public void CancelClicked()
    {
        DialogService.Close();
    }
    
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
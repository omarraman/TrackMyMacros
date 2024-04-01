using AutoMapper;
using Microsoft.AspNetCore.Components;
using Radzen;
using TrackMyMacros.App2.Services;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos.FoodCombo;

namespace TrackMyMacros.App2.Components;

public partial class AddFoodComboToMeal
{
    [Inject] public IFoodComboDataService _foodComboDataService { get; set; }
    
    [Inject] public DialogService DialogService { get; set; }

    [Parameter]
    public EventCallback<MealViewModel> OnSaveAndClose { get; set; }

    public IReadOnlyList<GetFoodComboDto> FoodCombos { get; set; }
    public Guid SelectedFoodComboId { get; set; }

    public List<string> AlertMessages { get; set; } = new List<string>();

    protected override async Task OnInitializedAsync()
    {
        
        await Refresh();
    }

    private async Task Refresh()
    {
        FoodCombos  = await _foodComboDataService.GetAllMealCombos();
// FoodCombos.Add(new GetFoodComboDto {Id = Guid.Empty, Name = "Select a food combo"});
        SelectedFoodComboId = Guid.Empty;
        
    }

    public async Task SaveAndClose()
    {
        if (SelectedFoodComboId== Guid.Empty)
        {
            AlertMessages.Add("You must select a food combo to add to the meal.");
            StateHasChanged();
            return;
        }
        var mealViewModel = await _foodComboDataService.GetMealCombo2(SelectedFoodComboId);
        
        await OnSaveAndClose.InvokeAsync(mealViewModel);
        DialogService.Close();
    }
    
    public async Task Cancel()
    {
        DialogService.Close();
    }
}
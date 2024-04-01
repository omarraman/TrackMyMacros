using AutoMapper;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Radzen;
using TrackMyMacros.App2.Components;
using TrackMyMacros.App2.Services;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;
using TrackMyMacros.Dtos.FoodCombo;

namespace TrackMyMacros.App2.Pages;

public partial class FoodComboList
{

    [Inject] public IFoodComboDataService _foodComboDataService { get; set; }
    
    [Inject] public DialogService DialogService { get; set; }
    [Inject] public IMapper Mapper { get; set; }

    public IReadOnlyList<GetFoodComboDto> FoodCombos { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        
        await Refresh();
    }

    private async Task Refresh()
    {
        FoodCombos  = await _foodComboDataService.GetAllMealCombos();

    }

    private async void EditFoodCombo(Guid id)
    {
        var foodComboDto = await _foodComboDataService.GetMealCombo(id);
        var meal= Mapper.Map<MealViewModel>(foodComboDto);
        meal.RefreshTotals();
        var json = JsonConvert.SerializeObject(meal);
        var mealCopy = JsonConvert.DeserializeObject<MealViewModel>(json);
        await DialogService.OpenAsync<CreateFoodComboDialog>("Edit Food Combo", new Dictionary<string, object>
        {
            { "Meal", mealCopy },
            { "DialogService", DialogService },
            {"FoodComboName", foodComboDto.Name},
            {"EditMode", true} ,
            {"Id", id},
            {"OnDialogClose", EventCallback.Factory.Create(this, OnDialogClose)}
            
        });
        // , new DialogOptions { Width = "400px" }
    }
    
    private async void DeleteFoodCombo(Guid id)
    {
        await _foodComboDataService.DeleteMealCombo(id);
        await Refresh();
        StateHasChanged();

    }
    
    public async Task OnDialogClose()
    {
        await Refresh();
        StateHasChanged();
    }
    
}
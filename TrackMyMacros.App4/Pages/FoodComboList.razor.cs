using AutoMapper;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Radzen;
using TrackMyMacros.App4.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.Dtos.FoodCombo;

namespace TrackMyMacros.App4.Pages
{
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
        var viewModel = await _foodComboDataService.GetMealCombo(id);
        // var meal= Mapper.Map<FoodComboViewModel>(foodComboDto);
        viewModel.RefreshTotals();
        var json = JsonConvert.SerializeObject(viewModel);
        var viewModelCopy = JsonConvert.DeserializeObject<FoodComboViewModel>(json);
        await DialogService.OpenAsync<CreateFoodComboDialog>("Edit Food Combo", new Dictionary<string, object>
        {
            { "Meal", viewModelCopy },
            { "DialogService", DialogService },
            {"FoodComboName", viewModel.Name},
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
}
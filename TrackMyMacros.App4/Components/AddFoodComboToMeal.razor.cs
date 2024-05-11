using Microsoft.AspNetCore.Components;
using Radzen;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.Dtos.FoodCombo;

namespace TrackMyMacros.App4.Components
{
    public partial class AddFoodComboToMeal
    {
        [Inject] public IFoodComboDataService _foodComboDataService { get; set; }
    
        [Inject] public DialogService DialogService { get; set; }

        [Parameter]
        public EventCallback<FoodComboViewModel> OnSaveAndClose { get; set; }

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
            var foodComboViewModel = await _foodComboDataService.GetMealCombo(SelectedFoodComboId);
        
            await OnSaveAndClose.InvokeAsync(foodComboViewModel);
            DialogService.Close();
        }
    
        public async Task Cancel()
        {
            DialogService.Close();
        }
    }
}
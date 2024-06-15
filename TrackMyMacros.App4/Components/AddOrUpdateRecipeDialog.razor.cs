using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModels.Recipe;
using TrackMyMacros.Dtos.Recipe;

namespace TrackMyMacros.App4.Components
{
    public partial class AddOrUpdateRecipeDialog
    {
        public async Task SaveAndClose()
        {
            if(!UpdateRecipeViewModel.SavingIsPossible)
            {
                AlertMessages.Add("Please add a valid food item");
                return;
            }

            if (string.IsNullOrEmpty(UpdateRecipeViewModel.Name.Trim()))
            {
                AlertMessages.Add("Please add a valid recipe name");

                return;
            }
            await DataService.Put<UpdateRecipeViewModel, UpdateRecipeDto>(UpdateRecipeViewModel, GenericDataService.Endpoints.Recipe);
            // InitializeViewModel();
            AlertMessages.Add("Record Updated");
            StateHasChanged();
        }

        // protected async override Task OnInitializedAsync()
        // {
        //     InitializeViewModel();
        // }
        //
        // private void InitializeViewModel()
        // {
        //     UpdateRecipeViewModel = new();
        // }

        [Inject]
        public IGenericDataService DataService { get; set; }
        public UpdateRecipeViewModel UpdateRecipeViewModel { get; set; }
        private List<string> AlertMessages { get; set; } = new();




        private void OnAddFood()
        {
            UpdateRecipeViewModel.FoodAmounts.Add(new FoodAmountViewModel() { FoodId = -1, Quantity = 10 });
            StateHasChanged();
        }

        private async Task RemoveFoodItem(FoodAmountViewModel foodAmount)
        {
            UpdateRecipeViewModel.FoodAmounts.Remove(foodAmount);
            UpdateRecipeViewModel.RefreshTotals();
            StateHasChanged();
        }

        private async Task OnQuantitiesChanged()
        {
            UpdateRecipeViewModel.RefreshTotals();
            StateHasChanged();
        }
        
    }
    
    
}
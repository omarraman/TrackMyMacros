using System.Diagnostics;
using Microsoft.AspNetCore.Components;
using Radzen;
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
            if(!RecipeViewModel.SavingIsPossible)
            {
                AlertMessages.Add("Please add a valid food item");
                return;
            }

            if (string.IsNullOrEmpty(RecipeViewModel.Name.Trim()))
            {
                AlertMessages.Add("Please add a valid recipe name");

                return;
            }
            await DataService.Put<RecipeViewModel, UpdateRecipeDto>(RecipeViewModel, GenericDataService.Endpoints.Recipe);
            // InitializeViewModel();
            AlertMessages.Add("Record Updated");
            await OnDialogClose.InvokeAsync();
            DialogService.Close();
        }

        protected async override Task OnInitializedAsync()
        {
            RecipeViewModel.RefreshTotals();
        }
        //
        // private void InitializeViewModel()
        // {
        //     UpdateRecipeViewModel = new();

        // }
        [Parameter]
        public RecipeViewModel RecipeViewModel { get; set; }

        [Parameter]
        public DialogService DialogService { get; set; }

        [Parameter]
        public EventCallback OnDialogClose { get; set; }

        [Inject]
        public IGenericDataService DataService { get; set; }

        private List<string> AlertMessages { get; set; } = new();


        
        
        private void OnAddFood()
        {
            RecipeViewModel.FoodAmounts.Add(new FoodAmountViewModel() { FoodId = -1, Quantity = 10 });
            StateHasChanged();
        }
        
        private async Task RemoveFoodItem(FoodAmountViewModel foodAmount)
        {
            RecipeViewModel.FoodAmounts.Remove(foodAmount);
            RecipeViewModel.RefreshTotals();
            StateHasChanged();
        }
        
        private async Task OnQuantitiesChanged()
        {
            RecipeViewModel.RefreshTotals();
            StateHasChanged();
        }
        
    }
    
    
}
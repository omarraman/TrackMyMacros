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
            if(!CreateRecipeViewModel.SavingIsPossible)
            {
                AlertMessages.Add("Please add a valid food item");
                return;
            }

            if (string.IsNullOrEmpty(CreateRecipeViewModel.Name.Trim()))
            {
                AlertMessages.Add("Please add a valid recipe name");

                return;
            }
            await DataService.Post<CreateRecipeViewModel, CreateRecipeDto>(CreateRecipeViewModel, GenericDataService.Endpoints.Recipe);
            InitializeViewModel();
            AlertMessages.Add("Record Added");
            StateHasChanged();
        }

        protected async override Task OnInitializedAsync()
        {
            InitializeViewModel();
        }

        private void InitializeViewModel()
        {
            CreateRecipeViewModel = new();
        }

        [Inject]
        public IGenericDataService DataService { get; set; }
        public CreateRecipeViewModel CreateRecipeViewModel { get; set; }
        private List<string> AlertMessages { get; set; } = new();




        private void OnAddFood()
        {
            CreateRecipeViewModel.FoodAmounts.Add(new FoodAmountViewModel() { FoodId = -1, Quantity = 10 });
            StateHasChanged();
        }

        private async Task RemoveFoodItem(FoodAmountViewModel foodAmount)
        {
            CreateRecipeViewModel.FoodAmounts.Remove(foodAmount);
            CreateRecipeViewModel.RefreshTotals();
            StateHasChanged();
        }

        private async Task OnQuantitiesChanged()
        {
            CreateRecipeViewModel.RefreshTotals();
            StateHasChanged();
        }
        
    }
    
    
}
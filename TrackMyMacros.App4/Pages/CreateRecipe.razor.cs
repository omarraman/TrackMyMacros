using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModels.Recipe;
using TrackMyMacros.Dtos.Recipe;


/*
                filename will be CreateRecipe.razor

                @page "/AddNewRecipe"
                @using global::TrackMyMacros.App4.ViewModels

                <div class="container">

                    <div class="row py-1">
                        <div class="col">
                            <RadzenDatePicker DateFormat="dd/MM/yyyy" @bind-Value="CreateRecipeViewModel.Date"/>
                        </div>
                    </div>
                    <div class="row py-1">
                        <div class="col">
                            <RadzenNumeric TValue="double" @bind-Value="CreateRecipeViewModel.Weight" Min="65" Max="85"></RadzenNumeric>
                        </div>
                    </div>
                    <div class="rz-p-12 rz-text-align-center">
                        <RadzenButton Text="Save" ButtonStyle="ButtonStyle.Secondary" Click="SaveAndClose"/>
                    </div>

                </div>

                @foreach (var alert in AlertMessages)
                {
                    <RadzenAlert AlertStyle="AlertStyle.Warning" Variant="Variant.Flat" Shade="Shade.Lighter">
                        Record saved
                     </RadzenAlert>
                }
*/
                
namespace TrackMyMacros.App4.Pages
{
    public partial class CreateRecipe
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
using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModels.Recipe;
using TrackMyMacros.Dtos.Recipe;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App4.Components
{
    public partial class MealRecipeItemComponent
    {
        private Maybe<RecipeViewModel> SelectedRecipe { get; set; }
        [Parameter] public RecipeViewModel Recipe { get; set; }
        [Inject] public IGenericDataService DataService { get; set; }
        [Parameter] public double Quantity { get; set; }

        [Parameter] public EventCallback<RecipeViewModel> OnRemove { get; set; }
        [Parameter] public EventCallback OnQuantitiesChanged { get; set; }

        public IReadOnlyList<RecipeViewModel> RecipeList { get; set; }=new List<RecipeViewModel>();


        public bool SliderDisabled { get; set; } = true;

        public decimal SliderMin { get; set; } = 0;
        public decimal SliderMax { get; set; } = 250;

        [Parameter] public Guid SelectedRecipeId  { get; set; }


        protected override async Task<Task> OnInitializedAsync()
        {
            RecipeList = await DataService.GetList<RecipeViewModel, GetRecipeDto>(GenericDataService.Endpoints.Recipe);
            SliderDisabled=SelectedRecipeId!= -1;

            SelectedRecipe= RecipeList.FirstOrDefault(x => x.Id == SelectedRecipeId)??Maybe<RecipeViewModel>.None
            // HandleSelectedRecipeDefaults(true);
            StateHasChanged();

            return base.OnInitializedAsync();
        }

        // private void HandleSelectedRecipeDefaults(bool initializing = false)
        // {
        //     //selected Recip is the record selected from the dropdown which has defaultquantity, min max etc
        //     if (SelectedRecipe.HasValue)
        //     {
        //         if (SelectedRecipe.Value.Min.HasValue) SliderMin = new decimal(SelectedRecipe.Value.Min.Value);
        //         if (SelectedRecipe.Value.Max.HasValue) SliderMax = new decimal(SelectedRecipe.Value.Max.Value);
        //
        //         if (initializing)
        //         {
        //             Recipe.SetQuantity(Recipe.Quantity,SelectedRecipe.Value);
        //             return;
        //         }
        //
        //         //apply default quantity f we are adding in a new item 
        //         if ( SelectedRecipe.Value.DefaultQuantity.HasValue) Recipe.SetQuantity(SelectedRecipe.Value.DefaultQuantity.Value, SelectedRecipe.Value);
        //         
        //     }
        // }


        // public RecipeViewModel GetRecipeViewModel()
        // {
        //     return new RecipeViewModel()
        //     {
        //         RecipId = Recipe.RecipId,
        //         Quantity = Quantity
        //     };
        // }


        private async Task RemoveRecipe()
        {
            await OnRemove.InvokeAsync(this.Recipe);
        }

        public async Task OnChangeRecipe(object args)
        {
            SelectedRecipe = RecipeList.FirstOrDefault(x => x.Id == Guid.Parse(args.ToString()));
            // HandleSelectedRecipeDefaults();
            SelectedRecipe.Value.RefreshTotals();
            await OnQuantitiesChanged.InvokeAsync();

        }
    
        public async Task OnChangeQuantity(double value)
        {
            SelectedRecipe.Value. = value;
            Recipe.SetQuantity(value, SelectedRecipe.Value);
            await OnQuantitiesChanged.InvokeAsync();

        }
    }
}
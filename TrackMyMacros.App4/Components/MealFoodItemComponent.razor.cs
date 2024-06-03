using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App4.Components
{
    public partial class MealFoodItemComponent
    {
        private Maybe<FoodListItemViewModel> SelectedFood { get; set; }
        [Inject] public IFoodDataRepository FoodDataRepository { get; set; }
        [Parameter] public double Quantity { get; set; }

        [Parameter] public EventCallback<FoodAmountViewModel> OnRemove { get; set; }
        [Parameter] public EventCallback OnQuantitiesChanged { get; set; }

        public IReadOnlyList<FoodListItemViewModel> FoodList { get; set; }

        [Parameter] public FoodAmountViewModel FoodAmount { get; set; }

        public bool SliderDisabled { get; set; } = true;

        public decimal SliderMin { get; set; } = 0;
        public decimal SliderMax { get; set; } = 250;

        [Parameter] public int SelectedFoodId  { get; set; }

        public MealFoodItemComponent()
        {
        }

        protected override async Task<Task> OnInitializedAsync()
        {
            FoodList = await FoodDataRepository.GetFoodList();
            SliderDisabled=SelectedFoodId!= -1;

            SelectedFood = FoodDataRepository.GetFood(FoodAmount.FoodId);
            HandleSelectedFoodDefaults(true);
            StateHasChanged();

            return base.OnInitializedAsync();
        }

        private void HandleSelectedFoodDefaults(bool initializing = false)
        {
            //selected food is the record selected from the dropdown which has defaultquantity, min max etc
            if (SelectedFood.HasValue)
            {
                if (SelectedFood.Value.Min.HasValue) SliderMin = new decimal(SelectedFood.Value.Min.Value);
                if (SelectedFood.Value.Max.HasValue) SliderMax = new decimal(SelectedFood.Value.Max.Value);

                if (initializing)
                {
                    FoodAmount.SetQuantity(FoodAmount.Quantity,SelectedFood.Value);
                    return;
                }

                //apply default quantity f we are adding in a new item 
                if ( SelectedFood.Value.DefaultQuantity.HasValue) FoodAmount.SetQuantity(SelectedFood.Value.DefaultQuantity.Value, SelectedFood.Value);
                
            }
        }


        public FoodAmountViewModel GetFoodAmountViewModel()
        {
            return new FoodAmountViewModel()
            {
                FoodId = FoodAmount.FoodId,
                Quantity = Quantity
            };
        }


        private async Task RemoveFood()
        {
            await OnRemove.InvokeAsync(this.FoodAmount);
        }

        public async Task OnChangeFood(object args)
        {
            SelectedFood = FoodDataRepository.GetFood(SelectedFoodId);
            HandleSelectedFoodDefaults();
            FoodAmount.SetMacros(SelectedFood.Value);
            await OnQuantitiesChanged.InvokeAsync();

        }
    
        public async Task OnChangeQuantity(double value)
        {
            FoodAmount.SetQuantity(value, SelectedFood.Value);
            await OnQuantitiesChanged.InvokeAsync();

        }
    }
}
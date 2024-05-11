using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Interfaces;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;

namespace TrackMyMacros.App4.Components
{
    public partial class FoodListItemComponent
    {
        [Inject] public IFoodDataService FoodDataService { get; set; }
        // [Parameter] public double Quantity { get; set; }

        // [Parameter] public string Guid { get; set; }
        // [Parameter] public EventCallback<FoodAmountViewModel> OnRemove { get; set; }
        // [Parameter] public EventCallback OnQuantitiesChanged { get; set; }

        [Parameter] public FoodListItemViewModel FoodListItemViewModel { get; set; }
        [Inject] public IUomDataService UomDataService { get; set; }
        public IReadOnlyList<UomViewModel> Uoms { get; set; }


        protected override async Task<Task> OnInitializedAsync()
        {
            // FoodList = await FoodDataRepository.GetFoodList();

            Uoms = await UomDataService.GetUoms();

            return base.OnInitializedAsync();
        }



        // public FoodAmountViewModel GetFoodAmountViewModel()
        // {
        //     return new FoodAmountViewModel()
        //     {
        //         FoodId = FoodAmount.FoodId,
        //         Quantity = Quantity
        //     };
        // }


        // private async Task RemoveFood()
        // {
        //     await OnRemove.InvokeAsync(this.FoodAmount);
        // }

        public async Task OnSaveFood(object args)
        {
            await FoodDataService.UpdateFood(FoodListItemViewModel);

        }

        // public async Task OnChangeQuantity(double value)
        // {
        //     FoodAmount.SetQuantity(value, SelectedFood.Value);
        //     await OnQuantitiesChanged.InvokeAsync();
        // }

    }
}
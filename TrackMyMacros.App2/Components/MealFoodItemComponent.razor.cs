using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Components;
using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Components;

public partial class MealFoodItemComponent
{
    
    private Maybe<FoodListItemViewModel> SelectedFood { get; set; }
    [Inject] public IFoodDataRepository FoodDataRepository { get; set; }
    [Parameter] public double Quantity { get; set; }
    
    [Parameter] public string Guid { get; set; }
    [Parameter] public EventCallback<FoodAmountViewModel> OnRemove { get; set; }
    public IReadOnlyList<FoodListItemViewModel> FoodList { get; set; }

    [Parameter] public FoodAmountViewModel FoodAmount { get; set; }


    public MealFoodItemComponent()
    {
    }

    protected override async Task<Task> OnInitializedAsync()
    {
        FoodList = await FoodDataRepository.GetFoodList();

        SelectedFood = FoodDataRepository.GetFood(FoodAmount.FoodId);

        return base.OnInitializedAsync();
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
}
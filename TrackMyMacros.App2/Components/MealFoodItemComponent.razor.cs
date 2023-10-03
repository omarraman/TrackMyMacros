using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Components;
using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Components;

public partial class MealFoodItemComponent
{
    private Maybe<FoodListItemViewModel> Food { get; set; }
    [Inject] public IFoodDataRepository FoodDataRepository { get; set; }
    [Parameter] public double Quantity { get; set; }
    [Parameter] public int FoodId { get; set; }
    [Parameter] public string Guid { get; set; }
    [Parameter] public EventCallback<string> OnRemove { get; set; }
    public IReadOnlyList<FoodListItemViewModel> FoodList { get; set; }


    // public string Guid { get;  }= System.Guid.NewGuid().ToString();

    public MealFoodItemComponent()
    {
    }

    protected override async Task<Task> OnInitializedAsync()
    {
        FoodList = await FoodDataRepository.GetFoodList();

        Food = FoodDataRepository.GetFood(FoodId);

        return base.OnInitializedAsync();
    }

    public FoodAmountViewModel GetFoodAmountViewModel()
    {
        return new FoodAmountViewModel()
        {
            FoodId = FoodId,
            Quantity = Quantity
        };
    }


    private async Task RemoveFood()
    {
        await OnRemove.InvokeAsync(this.Guid);
    }
}
using System.Diagnostics;

using Microsoft.AspNetCore.Components;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Dtos;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App2.Components;

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

    [Parameter] public int SelectedFoodId  { get; set; }

    public MealFoodItemComponent()
    {
    }

    protected override async Task<Task> OnInitializedAsync()
    {
        // SelectedFoodId = FoodAmount.FoodId;
        FoodList = await FoodDataRepository.GetFoodList();
        SliderDisabled=SelectedFoodId!= -1;

        SelectedFood = FoodDataRepository.GetFood(FoodAmount.FoodId);
        StateHasChanged();

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

    public async Task OnChangeFood(object args)
    {
        SelectedFood = FoodDataRepository.GetFood(SelectedFoodId);
        FoodAmount.SetMacros(SelectedFood.Value);
        await OnQuantitiesChanged.InvokeAsync();

    }
    
    public async Task OnChangeQuantity(double value)
    {
        FoodAmount.SetQuantity(value, SelectedFood.Value);
        await OnQuantitiesChanged.InvokeAsync();

    }
}
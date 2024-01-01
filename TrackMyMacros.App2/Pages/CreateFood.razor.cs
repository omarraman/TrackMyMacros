using Microsoft.AspNetCore.Components;
using TrackMyMacros.App2.Interfaces;
using TrackMyMacros.App2.Services;
using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Pages;

public partial class CreateFood
{
    [Inject] public IUomDataService UomDataService { get; set; }


    public List<string> AlertMessages { get; set; } = new List<string>();

    [Inject] public IFoodDataService FoodDataService { get; set; }
    public CreateFoodViewModel NewFood { get; set; } = new CreateFoodViewModel();

    protected async override Task OnInitializedAsync()
    {
        Uoms = await UomDataService.GetUoms();
        InitializeFood();
    }

    public IReadOnlyList<UomViewModel> Uoms { get; set; }

    private async Task HandleValidSubmit()
    {
        await FoodDataService.AddFood(NewFood);
        NewFood = new CreateFoodViewModel();
        AlertMessages.Add("Food Added");
        StateHasChanged();
    }

    private void InitializeFood()
    {
        NewFood = new CreateFoodViewModel
        {
            UomId = 1
        };
    }

}
using Microsoft.AspNetCore.Components;
using TrackMyMacros.App3.Interfaces;
using TrackMyMacros.App3.Services;
using TrackMyMacros.App3.ViewModels;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.App3.Components.Pages;

public partial class CreateFood
{
    [Inject] public IUomDataService UomDataService { get; set; }


    public List<string> AlertMessages { get; set; } = new List<string>();

    [Inject] public IFoodDataService FoodDataService { get; set; }
    [Inject] public IGenericDataService GenericDataService { get; set; }
    public CreateFoodViewModel NewFood { get; set; } = new CreateFoodViewModel();

    protected async override Task OnInitializedAsync()
    {
        Uoms = await UomDataService.GetUoms();
        InitializeFood();
    }

    public IReadOnlyList<UomViewModel> Uoms { get; set; }

    private async Task HandleValidSubmit()
    {
        await GenericDataService.Post<CreateFoodViewModel, CreateFoodDto>(NewFood, "/api/Food");
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
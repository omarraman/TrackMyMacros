using Microsoft.AspNetCore.Components;
using TrackMyMacros.App3.Interfaces;
using TrackMyMacros.App3.Services;
using TrackMyMacros.App3.ViewModels;

namespace TrackMyMacros.App3.Components;

public partial class AddFoodDialog
{
    
    [Inject]
    public IUomDataService UomDataService { get; set; }

    public bool Saved { get; set; } = false;

    [Inject] public IFoodDataService FoodDataService { get; set; }
    public CreateFoodViewModel NewFood { get; set; } = new CreateFoodViewModel();
    
    protected async override Task OnInitializedAsync()
    {
        Uoms = await UomDataService.GetUoms();
        NewFood.UomId = 1;
    }

    public IReadOnlyList<UomViewModel> Uoms { get; set; }

    private async Task HandleValidSubmit()
    {
         await FoodDataService.AddFood(NewFood);
         Saved= true;
    }

    /*
    private void HandleInvalidSubmit()
    {
    }

    private async Task HandleSubmit()
    {
        
    }*/
}
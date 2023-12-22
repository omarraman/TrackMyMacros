﻿using Microsoft.AspNetCore.Components;
using TrackMyMacros.App2.Interfaces;
using TrackMyMacros.App2.Services;
using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Pages;

public partial class FoodList
{
    [Inject]
    public IFoodDataService FoodDataService { get; set; }

    public bool ShowAddFoodDialog { get; set; }=false;
    
    protected async override Task OnInitializedAsync()
    {
        Foods = await FoodDataService.GetFoods();
    }

    public IReadOnlyList<FoodListItemViewModel> Foods { get; set; }

    public void Show()
    {
        ShowAddFoodDialog=true;
    }

}
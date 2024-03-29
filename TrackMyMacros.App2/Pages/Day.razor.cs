﻿using Microsoft.AspNetCore.Components;
using TrackMyMacros.App2.Components;
using TrackMyMacros.App2.Services;
using TrackMyMacros.App2.Services.DailyLimitsDataService;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App2.Pages;

public partial class Day
{
    [Inject] public IFoodDataRepository FoodDataRepository { get; set; }

    [Inject] public DayDataService DayDataService { get; set; }
    [Inject] public IDailyLimitsDataService DailyLimitsDataService { get; set; }

    private IReadOnlyList<FoodListItemViewModel> _foodList;
    public DayViewModel _day;

    public DateTime CurrentDate { get; set; } = DateTime.Now;
    
    
    private bool _noFoodIdSelectedOnOneOrMoreFoodItems = false;

    public Day()
    {
    }

    List<MealComponent2> ComponentRefs = new List<MealComponent2>();
    private Maybe<DailyLimitsViewModel> _dailyLimitsResult;

    MealComponent2 ComponentRef
    {
        set { ComponentRefs.Add(value); }
    }

    protected override async Task OnInitializedAsync()
    {
        _dailyLimitsResult = await DailyLimitsDataService.GetDailyLimits();


        // CurrentDate = DateOnly.FromDateTime(DateTime.Now);
        _foodList = await FoodDataRepository.GetFoodList();
        await Refresh();
        await base.OnInitializedAsync();
    }

    private async Task Refresh()
    {
        var getDay = await DayDataService.GetDay<DayViewModel>(DateOnly.FromDateTime(CurrentDate));
        if (getDay.HasNoValue)
        {
           
            _day= new DayViewModel
            {
                Date = DateOnly.FromDateTime(CurrentDate),
                Meals = new List<MealViewModel>()
            };
        }
        else
        {
            _day = getDay.Value;
        }
    }

    private async Task OnSave()
    {
        // var day = GetDayViewModel();
        if (_day.IsValid())
        {
            _noFoodIdSelectedOnOneOrMoreFoodItems = false;
            await DayDataService.UpdateDay(_day);
        }
        else
        {
            _noFoodIdSelectedOnOneOrMoreFoodItems = true;
        }
    }

    private async Task OnAddMeal()
    {
        _day.Meals.Add(new MealViewModel(Maybe<int>.None, Maybe<int>.None, Maybe<int>.None));
    }    
    private void OnMealMacrosChanged()
    {
        _day.RefreshTotals();

        StateHasChanged();
    }
    
    private async Task OnDateCHanged(DateTime? date)
    {
        CurrentDate = date?? DateTime.Now;
        await Refresh();
        StateHasChanged();
    }   
    
    
}
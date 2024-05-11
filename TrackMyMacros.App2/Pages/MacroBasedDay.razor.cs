using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Radzen;
using TrackMyMacros.App2.Components;
using TrackMyMacros.App2.Services;
using TrackMyMacros.App2.Services.DailyLimitsDataService;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Infrastructure;
using DateOnly = System.DateOnly;

namespace TrackMyMacros.App2.Pages;

public partial class MacroBasedDay
{
    [Inject] public IFoodDataRepository FoodDataRepository { get; set; }

    [Inject] public DayDataService DayDataService { get; set; }
    [Inject] public IDailyLimitsDataService DailyLimitsDataService { get; set; }
    [Inject] public DialogService DialogService { get; set; }

    private IReadOnlyList<FoodListItemViewModel> _foodList;
    public MacroBasedDayViewModel _day;

    public DateTime CurrentDate { get; set; } = DateTime.Now;
    
    
    private bool _noFoodIdSelectedOnOneOrMoreFoodItems = false;


    List<MealComponent2> ComponentRefs = new List<MealComponent2>();
    private Maybe<DailyLimitsViewModel> _dailyLimitsResult;
    MealComponent2 ComponentRef
    {
        set { ComponentRefs.Add(value); }
    }

    protected override async Task OnInitializedAsync()
    {
        _dailyLimitsResult = await DailyLimitsDataService.GetDailyLimits();
        if (_dailyLimitsResult.HasNoValue)
        {
            throw new Exception("No daily limit record found.");
        }

        // CurrentDate = DateOnly.FromDateTime(DateTime.Now);
        _foodList = await FoodDataRepository.GetFoodList();
        await Refresh();
        await base.OnInitializedAsync();
    }

    private async Task Refresh()
    {
        var getDay = await DayDataService.GetDay<MacroBasedDayViewModel>(DateOnly.FromDateTime(CurrentDate));
        if (getDay.HasNoValue)
        {
            _day = new MacroBasedDayViewModel(DateOnly.FromDateTime(CurrentDate),
                _dailyLimitsResult.Value.WeekdaysMealsPerDay,
                _dailyLimitsResult.Value.Protein
                , _dailyLimitsResult.Value.Carbohydrate
                , _dailyLimitsResult.Value.Fat);
        }
        else
        {
            _day = getDay.Value;
        }
        StateHasChanged();
        
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

    // private async Task OnAddMeal()
    // {
    //     _day.Meals.Add(new MealViewModel
    //     {
    //         FoodAmounts = new List<FoodAmountViewModel>
    //         {
    //             new FoodAmountViewModel
    //             {
    //                 FoodId = -1,
    //                 Quantity = 10
    //             }
    //         }
    //     });
    // }    
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

    public async Task ShowCopyMealsDialog()
    {
        Debug.WriteLine("ShowCopyMealsDialog");
        await DialogService.OpenAsync<CopyMealsToDateDialog>("Copy Meals1", new Dictionary<string, object>
        {
            { "DialogService", DialogService },
            { "OnCopyMealsToDate", EventCallback.Factory.Create<DateOnly>(this,CopyMealsFromCurrentDayToAnother) }
        });
        // , new DialogOptions { Width = "400px" }
    }

    private async Task CopyMealsFromCurrentDayToAnother(DateOnly targetDate)
    {
        var getDay = await DayDataService.GetDay<MacroBasedDayViewModel>(targetDate);
        MacroBasedDayViewModel targetDay;
        if (getDay.HasNoValue)
        {
            Console.WriteLine("CopyMealsFromCurrentDayToAnother2");
            Debug.WriteLine("CopyMealsFromCurrentDayToAnother2");
            targetDay = new MacroBasedDayViewModel(targetDate,  
                _dailyLimitsResult.Value.WeekdaysMealsPerDay,
                _dailyLimitsResult.Value.Protein
                , _dailyLimitsResult.Value.Carbohydrate
                , _dailyLimitsResult.Value.Fat);
        }
        else
        {
            Console.WriteLine("CopyMealsFromCurrentDayToAnother3");
            Debug.WriteLine("CopyMealsFromCurrentDayToAnother3");
            targetDay = getDay.Value;
        }
        targetDay.Meals.Clear();

        foreach (var meal in _day.Meals)
        {
            targetDay.Meals.Add(meal);
        }
        await DayDataService.UpdateDay(targetDay);
        // await Refresh();

    }
    


}
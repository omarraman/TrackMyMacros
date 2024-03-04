using Microsoft.AspNetCore.Components;
using TrackMyMacros.App2.Components;
using TrackMyMacros.App2.Services;
using TrackMyMacros.App2.Services.DailyLimitsDataService;
using TrackMyMacros.App2.ViewModels;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App2.Pages;

public partial class MacroBasedDay
{
    [Inject] public IFoodDataRepository FoodDataRepository { get; set; }

    [Inject] public DayDataService DayDataService { get; set; }
    [Inject] public IDailyLimitsDataService DailyLimitsDataService { get; set; }

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
    
    
}
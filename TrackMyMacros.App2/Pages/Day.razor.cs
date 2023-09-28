using Microsoft.AspNetCore.Components;
using Radzen.Blazor.Rendering;
using TrackMyMacros.App2.Components;
using TrackMyMacros.App2.Services;
using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Pages;

public partial class Day
{
    [Inject] public IFoodDataRepository FoodDataRepository { get; set; }

    [Inject] public DayDataService DayDataService { get; set; }

    private IReadOnlyList<FoodListItemViewModel> _foodList;
    public DayViewModel _day;
    
    private bool _noFoodIdSelectedOnOneOrMoreFoodItems=false;

    public Day()
    {
    }

    List<MealComponent2> ComponentRefs = new List<MealComponent2>();

    MealComponent2 ComponentRef
    {
        set { ComponentRefs.Add(value); }
    }

    public DayViewModel GetDayViewModel()
    {
        return new DayViewModel()
        {
            Date = _day.Date,
            Meals = ComponentRefs.Select(x => x.GetMealViewModel()).ToList()
        };
    }

    protected override async Task OnInitializedAsync()
    {
        _foodList = await FoodDataRepository.GetFoodList();
        _day = await DayDataService.GetDay(DateOnly.FromDateTime(DateTime.Now));
        await base.OnInitializedAsync();
    }
    
    private async Task OnSave()
    {
        var day = GetDayViewModel();
        if (day.IsValid())
        {
            _noFoodIdSelectedOnOneOrMoreFoodItems = false;
            await DayDataService.UpdateDay(day);
        }
        else
        {
            _noFoodIdSelectedOnOneOrMoreFoodItems = true;
        }
    }

}
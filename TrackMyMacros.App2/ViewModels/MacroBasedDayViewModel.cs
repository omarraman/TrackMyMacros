using Ardalis.GuardClauses;

namespace TrackMyMacros.App2.ViewModels;

public class MacroBasedDayViewModel
{
     public DateOnly Date { get; set; }

    public List<MealViewModel> Meals { get; set; }
    
    public bool IsValid()
    {
        return Meals.All(x => x.FoodAmounts.All(y => y.FoodId != -1));
    }
    public double Protein { get; set; }
    public double Carbohydrate { get; set; }
    public double Fat { get; set; }

    public int AllowedProtein { get; set; }
    public int AllowedCarbohydrate { get; set; }
    public int AllowedFat { get; set; }
    
    public double Calories =>   (Protein * 4) + (Carbohydrate * 4) + (Fat * 9);

    public int MealCount { get; set; }

    private MacroBasedDayViewModel()
    {
        
    }
    
    public MacroBasedDayViewModel(DateOnly currentDate,int mealCount, int allowedProtein, int allowedCarbohydrate, int allowedFat)
    {
        Date = currentDate;

        MealCount=Guard.Against.NegativeOrZero(mealCount, nameof(mealCount));
        AllowedProtein=Guard.Against.NegativeOrZero(allowedProtein, nameof(allowedProtein));
        AllowedCarbohydrate=Guard.Against.NegativeOrZero(allowedCarbohydrate, nameof(allowedCarbohydrate)) + WorkoutCarbs();
        AllowedFat=Guard.Against.NegativeOrZero(allowedFat, nameof(allowedFat));
        var allowedMealProtein =  Math.DivRem(AllowedProtein, mealCount, out var remainingMealProtein);
        var allowedMealFat =  Math.DivRem(allowedFat, mealCount, out var remainingMealFat);
        var allowedMealCarbohydrate =  Math.DivRem(AllowedCarbohydrate, mealCount, out var remainingMealCarbohydrate);
        MealCount = mealCount;
        Meals = new List<MealViewModel>();
        for (int i = 0; i < mealCount; i++)
        {
            Meals.Add(new MealViewModel(i == 0 ?allowedMealProtein+ remainingMealProtein : allowedMealProtein,
                i == 0 ?allowedMealCarbohydrate+ remainingMealCarbohydrate : allowedMealCarbohydrate,
                i == 0 ?allowedMealFat+ remainingMealFat : allowedMealFat));
        }



    }

    public int AllowedCalories => AllowedProtein * 4 + AllowedCarbohydrate * 4 + AllowedFat * 9; 
    

    private int WorkoutCarbs() =>
        Date.DayOfWeek == DayOfWeek.Monday || Date.DayOfWeek == DayOfWeek.Wednesday ||
        Date.DayOfWeek == DayOfWeek.Friday
            ? 50
            : 0;

    public void RefreshTotals()
    {
        Fat = 0;
        Protein= 0;
        Carbohydrate= 0;
        foreach (var mealViewModel in Meals)
        {
            Fat+= mealViewModel.Fat;
            Carbohydrate+= mealViewModel.Carbohydrate;
            Protein+= mealViewModel.Protein;
        }

    }
}


// public class MacroBasedMealViewModel:MealViewModel
// {
//
//     public int AllowedProtein { get; set; }
//     public int AllowedCarbohydrate { get; set; }
//     public int AllowedFat { get; set; }
//
//
//     public MacroBasedMealViewModel(int allowedProtein, int allowedCarbohydrate, int allowedFat)
//     {
//         FoodAmounts = new List<FoodAmountViewModel>();
//         AllowedProtein = allowedProtein;
//         AllowedCarbohydrate = allowedCarbohydrate;
//         AllowedFat = allowedFat;
//     }
//
// }
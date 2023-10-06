using CSharpFunctionalExtensions;

namespace TrackMyMacros.App2.ViewModels;

public class DayViewModel
{
    public DateOnly Date { get; set; }

    public List<MealViewModel> Meals { get; set; }
    
    public bool IsValid()
    {
        return Meals.All(x => x.FoodAmounts.All(y => y.FoodId != -1));
    }
}

public class MealViewModel
{
    public List<FoodAmountViewModel> FoodAmounts { get; set; }

    public Double TotalProtein {
        get
        {
            return FoodAmounts.ForEach(m=>m.)
        }
    }
}

public class FoodAmountViewModel
{
    public int FoodId { get; set; }
    public double Quantity { get; set; }

    public decimal Protein { get; set; }
    
}

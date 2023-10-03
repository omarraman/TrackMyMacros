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
}
public class FoodAmountViewModel
{
    public string Guid { get; } = System.Guid.NewGuid().ToString();
    public int FoodId { get; set; }
    public double Quantity { get; set; }
}

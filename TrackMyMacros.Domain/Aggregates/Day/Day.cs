using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Day;

public class Day
{
    public Guid Id { get; set; }
    public DateOnly Date { get; set; }
    public List<Meal> Meals { get; set; } = new();
    
    public void AddMeal(Meal meal)
    {
        Meals.Add(meal);
    }
    
    public double GetTotalCalories()
    {
        return Meals.Sum(x => x.GetTotalCalories());
    }
    
    public IReadOnlyList<Meal> GetMeals()
    {
        return Meals.AsReadOnly();
    }
}

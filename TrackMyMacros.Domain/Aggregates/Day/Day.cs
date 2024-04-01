using TrackMyMacros.Domain.ValueObjects;

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
    public double Protein { get; set; }
    public double Carbohydrate { get; set; }
    public double Fat { get; set; }
    public int AllowedProtein { get; set; }
    public int AllowedCarbohydrate { get; set; }
    public int AllowedFat { get; set; }
    public int MealCount { get; set; }
    public Day()
    {
        
    }
    // public Day(double protein,double carbohydrate, double fat)
    // {
    //     Guard.Against.NegativeOrZero(protein, nameof(protein));
    //     Guard.Against.NegativeOrZero(carbohydrate, nameof(carbohydrate));
    //     Guard.Against.NegativeOrZero(fat, nameof(fat));
    //     Protein= protein;
    //     Carbohydrate= carbohydrate;
    //     Fat= fat;
    // }
}

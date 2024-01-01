using TrackMyMacros.Domain.Common;
using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Domain.Aggregates.Day;

public class Meal : ValueObject<Meal>
{
    public List<FoodAmount> FoodAmounts { get; } = new();

    public void AddFoodItem(FoodAmount foodAmount)
    {
        FoodAmounts.Add(foodAmount);
    }

    public double GetTotalCalories()
    {
        return FoodAmounts.Sum(x => x.GetCalories());
    }

    public IReadOnlyList<FoodAmount> GetFoodAmounts()
    {
        return FoodAmounts.AsReadOnly();
    }

    protected override bool EqualsCore(Meal other)
    {
        throw new NotImplementedException();
    }

    protected override int GetHashCodeCore()
    {
        throw new NotImplementedException();
    }

    public double Protein { get; set; }
    public double Carbohydrate { get; set; }
    public double Fat { get; set; }

    // public Meal(double protein,double carbohydrate, double fat)
    // {
    //     Guard.Against.NegativeOrZero(protein, nameof(protein));
    //     Guard.Against.NegativeOrZero(carbohydrate, nameof(carbohydrate));
    //     Guard.Against.NegativeOrZero(fat, nameof(fat));
    //     Protein= protein;
    //     Carbohydrate= carbohydrate;
    //     Fat= fat;
    // }
}
using Ardalis.GuardClauses;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.ValueObjects;

public class FoodAmount:ValueObject<FoodAmount>
{
    private FoodAmount()
    {
        
    }
    public double Quantity { get; }
    
    // public Food Food { get; set; }
    public int FoodId { get; }

    public FoodAmount(int foodId, double quantity,double protein,double carbohydrate, double fat)
    {
        Guard.Against.Null(foodId, nameof(foodId));
        Guard.Against.NegativeOrZero(quantity, nameof(quantity));
        Guard.Against.NegativeOrZero(protein, nameof(protein));
        Guard.Against.NegativeOrZero(carbohydrate, nameof(carbohydrate));
        Guard.Against.NegativeOrZero(fat, nameof(fat));
        Protein= protein;
        Carbohydrate= carbohydrate;
        Fat= fat;
        FoodId = foodId;
        Quantity = quantity;
    }

    protected override bool EqualsCore(FoodAmount other)
    {
        return FoodId==other.FoodId && Quantity== other.Quantity;
    }

    protected override int GetHashCodeCore()
    {
        return this.FoodId.GetHashCode() ^ this.Quantity.GetHashCode() * 17;
    }
    
    public double GetCalories()
    {
        // return Food.Calories * Quantity;
        throw new NotImplementedException();
    }

    public double Protein { get; set; }
    public double Carbohydrate { get; set; }
    public double Fat { get; set; }
}
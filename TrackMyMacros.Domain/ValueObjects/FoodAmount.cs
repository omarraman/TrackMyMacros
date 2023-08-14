using Ardalis.GuardClauses;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.ValueObjects;

public class FoodAmount:ValueObject<FoodAmount>
{
    public double Quantity { get; }
    
    // public Food Food { get; set; }
    public int FoodId { get;
         }

    public FoodAmount(int foodId, double quantity)
    {
        Guard.Against.Null(foodId, nameof(foodId));
        Guard.Against.NegativeOrZero(quantity, nameof(quantity));
        
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
}
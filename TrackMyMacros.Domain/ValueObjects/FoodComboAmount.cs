using Ardalis.GuardClauses;
using TrackMyMacros.Attributes;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.ValueObjects;

[CodeGen]
public class FoodComboAmount:ValueObject<FoodComboAmount>
{

    public FoodComboAmount()
    {
        
    }

    public int Id { get; set; }
    public double Quantity { get; set; }
    
    // public Food Food { get; set; }
    public int FoodId { get; set; }

    // public FoodComboAmount(int foodId, double quantity)
    // {
    //     Guard.Against.Null(foodId, nameof(foodId));
    //     Guard.Against.NegativeOrZero(quantity, nameof(quantity));
    //     FoodId = foodId;
    //     Quantity = quantity;
    // }

    protected override bool EqualsCore(FoodComboAmount other)
    {
        return FoodId==other.FoodId && Quantity== other.Quantity;
    }


    protected override int GetHashCodeCore()
    {
        return this.FoodId.GetHashCode() ^ this.Quantity.GetHashCode() * 17;
    }
    
    public double Protein { get; set; }
    public double Carbohydrate { get; set; }
    public double Fat { get; set; }
    
}
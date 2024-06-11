using TrackMyMacros.Attributes;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.ValueObjects;

[CodeGen]
public class RecipeFoodAmount:ValueObject<RecipeFoodAmount>
{

    public RecipeFoodAmount()
    {
        
    }

    public int Id { get; set; }
    public double Quantity { get; set; }
    
    public int FoodId { get; set; }

    protected override bool EqualsCore(RecipeFoodAmount other)
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
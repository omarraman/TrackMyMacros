using Ardalis.GuardClauses;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.ValueObjects;

public class MacroNutrientAmount:ValueObject<MacroNutrientAmount>
{
    public  MacroNutrient2 MacroNutrient{ get; private set; }
    public double Quantity { get; private set; }

    public MacroNutrientAmount(MacroNutrient2 macroNutrient, double quantity)
    {
        MacroNutrient = macroNutrient;
        Quantity = Guard.Against.Negative(quantity, nameof(quantity));
    }
    protected override bool EqualsCore(MacroNutrientAmount other)
    {
        return Quantity== other.Quantity && MacroNutrient == other.MacroNutrient;
    }

    protected override int GetHashCodeCore()
    {
        return  this.Quantity.GetHashCode() +  this.MacroNutrient.CaloriesPerGram.GetHashCode() * 17;
    }
}
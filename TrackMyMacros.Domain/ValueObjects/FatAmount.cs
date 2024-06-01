namespace TrackMyMacros.Domain.ValueObjects;

public class FatAmount: MacroNutrientAmount
{
    public FatAmount(double quantity):base(MacroNutrient2.Fat , quantity)
    {
    }
}
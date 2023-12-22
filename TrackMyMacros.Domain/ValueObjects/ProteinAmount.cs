using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Domain;

public class ProteinAmount: MacroNutrientAmount
{
    public ProteinAmount(double quantity):base(MacroNutrient2.Carbohydrate , quantity)
    {
    }
}
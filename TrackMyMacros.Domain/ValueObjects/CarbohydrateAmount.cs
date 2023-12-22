using Ardalis.GuardClauses;
using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Domain;

public class CarbohydrateAmount: MacroNutrientAmount
{
    public CarbohydrateAmount(double quantity):base(MacroNutrient2.Carbohydrate , quantity)
    {
    }
}
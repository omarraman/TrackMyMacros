using Ardalis.GuardClauses;
using TrackMyMacros.Attributes;
using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Domain.Aggregates;

public class Food 
{
    public int Id { get; set; }

    public Guid? Guid { get; set; }
    public string Name { get; set; }
    [CodeGenIgnoreMember]
    public CarbohydrateAmount CarbohydrateAmount { get; set; }
    [CodeGenIgnoreMember]
    public ProteinAmount ProteinAmount { get; set; }
    [CodeGenIgnoreMember]
    public FatAmount FatAmount { get; set; }

    public double Quantity { get; set; }
    public int QuantityInGrams { get; set; }

    public double? DefaultQuantity { get; set; }
    public double? Min { get; set; }
    public double? Max { get; set; }

    public Guid RecipeId { get; set; }
    public int UomId { get; set; }

    [CodeGenIgnoreMember]
    public double Calories => CarbohydrateAmount.MacroNutrient.CaloriesPerGram * QuantityInGrams +
                              ProteinAmount.MacroNutrient.CaloriesPerGram * QuantityInGrams +
                              FatAmount.MacroNutrient.CaloriesPerGram * QuantityInGrams;

}
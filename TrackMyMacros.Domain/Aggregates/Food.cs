using TrackMyMacros.Attributes;

namespace TrackMyMacros.Domain.Aggregates;

[CodeGen]
public class Food 
{
    public int Id { get; set; }
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

    public int UomId { get; set; }

    [CodeGenIgnoreMember]
    public double Calories => CarbohydrateAmount.MacroNutrient.CaloriesPerGram * QuantityInGrams +
                              ProteinAmount.MacroNutrient.CaloriesPerGram * QuantityInGrams +
                              FatAmount.MacroNutrient.CaloriesPerGram * QuantityInGrams;

    //slice half a slice 2 slices
    //bar
    //100g 30 g 200g
}
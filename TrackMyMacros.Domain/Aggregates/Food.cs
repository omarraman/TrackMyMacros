namespace TrackMyMacros.Domain.Aggregates;

public class Food 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public CarbohydrateAmount CarbohydrateAmount { get; set; }
    public ProteinAmount ProteinAmount { get; set; }
    public FatAmount FatAmount { get; set; }

    public double Quantity { get; set; }
    public int QuantityInGrams { get; set; }

    public double? DefaultQuantity { get; set; }

    public int UomId { get; set; }

    public double Calories => CarbohydrateAmount.MacroNutrient.CaloriesPerGram * QuantityInGrams +
                              ProteinAmount.MacroNutrient.CaloriesPerGram * QuantityInGrams +
                              FatAmount.MacroNutrient.CaloriesPerGram * QuantityInGrams;

    //slice half a slice 2 slices
    //bar
    //100g 30 g 200g
}
using TrackMyMacros.Attributes;
using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Domain.Aggregates.Recipe;

[CodeGen]
public class Recipe
{
    
    public Guid Id { get; set; }

    public string Name { get; set; }
    public List<RecipeFoodAmount> RecipeFoodAmounts { get; }= new();

    public Guid FoodId { get; set; }
    public double ProteinPer100G => ProteinPerGram * 100;
    public double ProteinPerGram => TotalProtein/Weight;
    
    public double TotalProtein => RecipeFoodAmounts.Sum(m => m.Protein);

    public double FatPer100G => FatPerGram * 100;
    public double FatPerGram => TotalFat / Weight;
    public double TotalFat => RecipeFoodAmounts.Sum(m => m.Fat);
    
    public double CarbohydratePer100G => CarbohydratePerGram * 100;
    public double CarbohydratePerGram => TotalCarbohydrate / Weight;
    public double TotalCarbohydrate => RecipeFoodAmounts.Sum(m => m.Carbohydrate);

    public double Weight => RecipeFoodAmounts.Sum(m => m.Quantity);

}
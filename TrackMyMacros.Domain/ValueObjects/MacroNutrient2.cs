using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.ValueObjects;

public class MacroNutrient2:ValueObject<MacroNutrient2>

{
    // public int Id { get; }
    public int CaloriesPerGram { get; private set; }
    
    public static MacroNutrient2 Carbohydrate = new(1,4);
    public static MacroNutrient2 Protein = new(2,4);
    public static MacroNutrient2 Fat = new(3,9);
    
    private MacroNutrient2(int id,int caloriesPerGram)
    {
        // Id = id;
        this.CaloriesPerGram = caloriesPerGram;
    }

    protected override bool EqualsCore(MacroNutrient2 other)
    {
        return this.CaloriesPerGram== other.CaloriesPerGram;
    }

    protected override int GetHashCodeCore()
    {
        return  this.CaloriesPerGram.GetHashCode() * 17;
    }
}
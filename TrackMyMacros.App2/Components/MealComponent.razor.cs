namespace TrackMyMacros.App2.Components;

public partial class MealComponent
{
    public double Type { get; set; }
    public List<FoodItem> FoodItems { get; set; } = new List<FoodItem>();
    
    
}

public class FoodItem
{
    public double Quantity { get; set; }
    public int FoodId { get; set; }
}
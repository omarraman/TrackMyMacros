
namespace TrackMyMacros.Application.Features.FoodCombo.Commands.Update;

public class UpdateFoodComboCommand:RequestBase<Result>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<UpdateFoodComboAmount> FoodComboAmounts { get; set; }
    
    
    public class UpdateFoodComboAmount
    {
        public int FoodId { get; set; }
        public double Quantity { get; set; }
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fat { get; set; }
    }
}

namespace TrackMyMacros.Application.Features.FoodCombo.Commands.Create;

public class CreateFoodComboCommand:RequestBase<Result<Guid>>
{
    public string Name { get; set; }
    public List<CreateFoodComboAmount> FoodComboAmounts { get; set; }
    


}

public class CreateFoodComboAmount
{
    public int FoodId { get; set; }
    public double Quantity { get; set; }
    
    public double Protein { get; set; }
    public double Carbohydrate { get; set; }
    public double Fat { get; set; }
}



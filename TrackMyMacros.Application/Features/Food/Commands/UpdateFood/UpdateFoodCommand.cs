
namespace TrackMyMacros.Application.Features.Food.Commands.UpdateFood;

public class UpdateFoodCommand:RequestBase<Result>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Carbohydrate { get; set; }
    public double Protein { get; set; }
    public double Fat { get; set; }

    public double Quantity { get; set; }
    public double? DefaultQuantity { get; set; }
    public double? Min { get; set; }
    public double? Max { get; set; }
    public int UomId { get; set; }

}
namespace TrackMyMacros.Dtos.FoodCombo;

public class GetFoodComboDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public List<GetFoodComboAmountDto> FoodComboAmounts { get; set; } 
}   
namespace TrackMyMacros.Dtos.FoodCombo;

public class CreateFoodComboDto
{
    public string Name { get; set; }

    public List<CreateFoodComboAmountDto> FoodComboAmounts { get; set; } 
}
namespace TrackMyMacros.Dtos.FoodCombo;

public class UpdateFoodComboDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public List<UpdateFoodComboAmountDto> FoodComboAmounts { get; set; } 
    
    public class UpdateFoodComboAmountDto
    {
        public int FoodId { get; set; }
        public double Quantity { get; set; }
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fat { get; set; }
    }
}
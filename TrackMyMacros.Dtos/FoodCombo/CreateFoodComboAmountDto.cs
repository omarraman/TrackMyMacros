namespace TrackMyMacros.Dtos.FoodCombo;

public class CreateFoodComboAmountDto
{
    public int FoodId { get; set; }
    public double Quantity { get; set; }
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fat { get; set; }
}
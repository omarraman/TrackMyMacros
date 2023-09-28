namespace TrackMyMacros.Dtos;

public class UpdateDayDto
{
    public DateOnly Date {get; set; }

    public List<Meal> Meals {get; set; }
    
    public class Meal
    {
        public List<FoodAmount> FoodAmounts {get; set; } 
    }
    
    public class FoodAmount
    {
        public int FoodId {get; set; }
        public double Quantity {get; set; }
    }


}






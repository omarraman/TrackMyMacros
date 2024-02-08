namespace TrackMyMacros.Dtos;

public class UpdateDayDto
{
    public DateOnly Date {get; set; }

    public List<Meal> Meals {get; set; }
    
    public double Protein { get; set; }
    public double Carbohydrate { get; set; }
    public double Fat { get; set; }
    public int AllowedProtein { get; set; }
    public int AllowedCarbohydrate { get; set; }
    public int AllowedFat { get; set; }
    public class Meal
    {
        public List<FoodAmount> FoodAmounts {get; set; } 
        
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fat { get; set; }
        public int AllowedProtein { get; set; }
        public int AllowedCarbohydrate { get; set; }
        public int AllowedFat { get; set; }
    }
    
    public class FoodAmount
    {
        public int FoodId {get; set; }
        public double Quantity {get; set; }
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fat { get; set; }
    }


    

}






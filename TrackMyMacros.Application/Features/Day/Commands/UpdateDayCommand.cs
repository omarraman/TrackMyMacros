
namespace TrackMyMacros.Application.Features.Day.Commands;

public class UpdateDayCommand:RequestBase<Result>
{
    public DateOnly Date {get; set; }

    public List<UpdateMeal> Meals {get; set; }
    
    public class UpdateMeal
    {
        public List<UpdateFoodAmount> FoodAmounts {get; set; } 
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fat { get; set; }
        
    }

    public double Protein { get; set; }
    public double Carbohydrate { get; set; }
    public double Fat { get; set; }

    public class UpdateFoodAmount
    {
        public int FoodId {get; set; } 
        public double Quantity {get; set; }
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fat { get; set; }
    }

}





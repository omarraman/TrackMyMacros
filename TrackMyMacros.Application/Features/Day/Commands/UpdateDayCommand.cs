using CSharpFunctionalExtensions;
using MediatR;

namespace TrackMyMacros.Application.Features.Day.Commands;

public class UpdateDayCommand:IRequest<Result>
{
    public DateOnly Date {get; set; }

    public List<UpdateMeal> Meals {get; set; }
    
    public class UpdateMeal
    {
        public List<UpdateFoodAmount> FoodAmounts {get; set; } 
        
    }

    public class UpdateFoodAmount
    {
        public int FoodId {get; set; } 
        public double Quantity {get; set; }
    }

}





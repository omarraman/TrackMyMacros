using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App2.ViewModels;

public class MealViewModel
{
    public List<FoodAmountViewModel> FoodAmounts { get; set; }
    
    public double Protein { get; set; }
    public double Carbohydrate { get; set; }
    public double Fat { get; set; }
    public double Calories =>   (Protein * 4) + (Carbohydrate * 4) + (Fat * 9);

    public void RefreshTotals()
    {
        Fat = 0;
        Protein= 0;
        Carbohydrate= 0;
        foreach (var foodAmountViewModel in FoodAmounts)
        {
            Fat+= foodAmountViewModel.Fat;
            Carbohydrate+= foodAmountViewModel.Carbohydrate;
            Protein+= foodAmountViewModel.Protein;
        }

    }
     public int AllowedProtein { get; set; }
     public int AllowedCarbohydrate { get; set; }
     public int AllowedFat { get; set; }

     private MealViewModel()
     {
         
     }

     public MealViewModel(int allowedProtein, int allowedCarbohydrate, int allowedFat)
     {
         FoodAmounts = new List<FoodAmountViewModel>();
         AllowedProtein = allowedProtein;
         AllowedCarbohydrate = allowedCarbohydrate;
         AllowedFat = allowedFat;

         FoodAmounts = new List<FoodAmountViewModel>();

     }
}
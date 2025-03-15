using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.ViewModels
{
    public class DayViewModel
    {
        public DateOnly Date { get; set; }

        public List<MealViewModel> Meals { get; set; }
    
        public bool IsValid()
        {
            return Meals.All(x => x.FoodAmounts.All(y => y.FoodId != -1));
        }
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fat { get; set; }
    
        public double Calories =>   (Protein * 4) + (Carbohydrate * 4) + (Fat * 9);
    
        public Maybe<int> AllowedProtein { get; set; }
        public Maybe<int> AllowedCarbohydrate { get; set; }
        public Maybe<int> AllowedFat { get; set; }
    

        public Maybe<int> MealCount { get; set; }

    


        public void RefreshTotals()
        {
            Fat = 0;
            Protein= 0;
            Carbohydrate= 0;
            foreach (var mealViewModel in Meals)
            {
                Fat+= mealViewModel.Fat;
                Carbohydrate+= mealViewModel.Carbohydrate;
                Protein+= mealViewModel.Protein;
            }

        }
    }
}
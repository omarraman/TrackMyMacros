namespace TrackMyMacros.App4.ViewModels
{
    public class MealViewModel : FoodCollectionViewModel

    {
        public int AllowedProtein { get; set; }
        public int AllowedCarbohydrate { get; set; }
        public int AllowedFat { get; set; }


        public MealViewModel(int allowedProtein, int allowedCarbohydrate, int allowedFat)
        {
            AllowedProtein = allowedProtein;
            AllowedCarbohydrate = allowedCarbohydrate;
            AllowedFat = allowedFat;
        }
    }
}
using System.ComponentModel.DataAnnotations;

namespace TrackMyMacros.App2.ViewModels;

public class DailyLimitsViewModel
{
        [Range(1, 3500, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Calories { get; set; }
        public int Protein => Convert.ToInt32(WeightInLbs*0.86);
        public int Fat =>  Convert.ToInt32(WeightInLbs * 0.3);
        public int Carbohydrate => (Calories - (Protein * 4) - (Fat * 9))/4;
        [Range(70, 100, ErrorMessage = "Please enter a value bigger than {1}")]
        public double WeightInKg { get; set; }
        private double WeightInLbs => WeightInKg * 2.20462;
        
        public int WeekdaysMealsPerDay { get; set; }
        public int     WeekendMealsPerDay { get; set; }
}
namespace TrackMyMacros.App2.ViewModels;

public class DailyLimitsViewModel
{
        public int Calories { get; set; }
        public int Protein => Convert.ToInt32(WeightInLbs);
        public int Fat =>  Convert.ToInt32(WeightInLbs * 0.3);
        public int Carbohydrate => (Calories - (Protein * 4) - (Fat * 9))/4;
        
        public double WeightInKg { get; set; }
        private double WeightInLbs => WeightInKg * 2.20462;
}
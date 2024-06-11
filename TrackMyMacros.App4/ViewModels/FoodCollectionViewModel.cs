namespace TrackMyMacros.App4.ViewModels
{
    public abstract class FoodCollectionViewModel
    {
        public List<FoodAmountViewModel> FoodAmounts { get; set; } = new List<FoodAmountViewModel>();
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fat { get; set; }
        public double Calories => (Protein * 4) + (Carbohydrate * 4) + (Fat * 9);

        public void RefreshTotals()
        {
            Fat = 0;
            Protein = 0;
            Carbohydrate = 0;
            foreach (var foodAmountViewModel in FoodAmounts)
            {
                Fat += foodAmountViewModel.Fat;
                Carbohydrate += foodAmountViewModel.Carbohydrate;
                Protein += foodAmountViewModel.Protein;
            }

        }

        public bool SavingIsPossible
        {
            get { return FoodAmounts.Count > 0 && FoodAmounts.All(x => x.FoodId != -1); }
        }
    }
}
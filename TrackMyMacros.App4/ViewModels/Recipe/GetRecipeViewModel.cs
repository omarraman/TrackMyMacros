namespace TrackMyMacros.App4.ViewModels.Recipe
{
    public class GetRecipeViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<GetRecipeFoodAmountViewModel> RecipeFoodAmounts { get; set; }

        public class GetRecipeFoodAmountViewModel
        {
            public int Id { get; set; }
            public double Quantity { get; set; }
            public int FoodId { get; set; }
            public double Protein { get; set; }
            public double Carbohydrate { get; set; }
            public double Fat { get; set; }
        }
    }
}
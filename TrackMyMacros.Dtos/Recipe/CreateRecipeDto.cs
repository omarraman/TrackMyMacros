namespace TrackMyMacros.Dtos.Recipe
{
    public class CreateRecipeDto
    {
        public string Name { get; set; }
        public List<CreateRecipeFoodAmountDto> RecipeFoodAmounts { get; set; }

        public class CreateRecipeFoodAmountDto
        {
            public double Quantity { get; set; }
            public int FoodId { get; set; }
            public double Protein { get; set; }
            public double Carbohydrate { get; set; }
            public double Fat { get; set; }
        }
    }
}
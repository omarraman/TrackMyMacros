namespace TrackMyMacros.Dtos.Recipe
{
    public class GetRecipeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<GetRecipeFoodAmountDto> RecipeFoodAmounts { get; set; }

        public class GetRecipeFoodAmountDto
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
namespace TrackMyMacros.Application.Features.Recipe.Commands.Update
{
    public class UpdateRecipeCommand : RequestBase<Result>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<UpdateRecipeFoodAmount> RecipeFoodAmounts { get; set; }

        public class UpdateRecipeFoodAmount
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
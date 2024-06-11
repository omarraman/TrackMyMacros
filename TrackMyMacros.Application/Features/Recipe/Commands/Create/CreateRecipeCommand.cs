namespace TrackMyMacros.Application.Features.Recipe.Commands.Create
{
    public class CreateRecipeCommand : RequestBase<Result<Guid>>
    {
        public string Name { get; set; }
        public List<CreateRecipeFoodAmount> RecipeFoodAmounts { get; set; }

        public class CreateRecipeFoodAmount
        {
            public double Quantity { get; set; }
            public int FoodId { get; set; }
            public double Protein { get; set; }
            public double Carbohydrate { get; set; }
            public double Fat { get; set; }
        }
    }
}
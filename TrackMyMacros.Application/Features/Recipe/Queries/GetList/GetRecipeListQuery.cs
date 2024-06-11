using TrackMyMacros.Dtos.Recipe;

namespace TrackMyMacros.Application.Features.Recipe.Queries.GetList
{
    public class GetRecipeListQuery : RequestBase<IReadOnlyList<GetRecipeDto>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<GetListRecipeFoodAmount> RecipeFoodAmounts { get; set; }

        public class GetListRecipeFoodAmount
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
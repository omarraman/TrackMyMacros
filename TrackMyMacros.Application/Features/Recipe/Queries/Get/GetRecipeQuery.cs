using TrackMyMacros.Dtos.Recipe;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Features.Recipe.Queries.Get
{
    public class GetRecipeQuery : RequestBase<Maybe<GetRecipeDto>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<GetRecipeFoodAmount> RecipeFoodAmounts { get; set; }

        public class GetRecipeFoodAmount
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
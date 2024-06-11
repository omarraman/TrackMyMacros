using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMyMacros.Domain.Aggregates.Recipe;

namespace TrackMyMacros.Persistance.Repositories;

public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
{
    public void Configure(EntityTypeBuilder<Recipe> builder)
    {
        var RecipeId = Guid.NewGuid();

        builder.OwnsMany(m => m.RecipeFoodAmounts, recipeAmount =>
            {
                recipeAmount.WithOwner().HasForeignKey("RecipeId");
                recipeAmount.Property(m => m.Quantity)
                    .IsRequired();
                recipeAmount.Property(m => m.FoodId)
                    .IsRequired();
            }

        );

    }
}
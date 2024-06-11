using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.Aggregates.FoodCombo;
using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Persistance.Repositories;

public class FoodComboConfiguration : IEntityTypeConfiguration<FoodCombo>
{
    public void Configure(EntityTypeBuilder<FoodCombo> builder)
    {
        var FoodComboId = Guid.NewGuid();


        var foodAmountsList = new List<object>()
        {
            new { FoodComboId=FoodComboId, Id= 1,FoodId=1,Quantity=40D,Protein=10D,Carbohydrate=10D,Fat=10D},
            new { FoodComboId=FoodComboId, Id= 2,FoodId=2, Quantity= 200D,Protein=10D,Carbohydrate=10D,Fat=10D},
        };

        builder.OwnsMany(m => m.FoodComboAmounts, foodComboAmount =>
            {
                foodComboAmount.WithOwner().HasForeignKey("FoodComboId");
                foodComboAmount.Property(m => m.Quantity)
                    .IsRequired();
                foodComboAmount.Property(m => m.FoodId)
                    .IsRequired();
                foodComboAmount.HasData(foodAmountsList);
            }

        ).HasData(new {Id = FoodComboId, Name = "Test Food Combo", CreatedDate = DateTime.UtcNow});

    }
}
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
        //
        //
        // var newDayGuid = Guid.NewGuid();
        // var foodAmounts = new List<object>()
        // {
        //     new { DayId=newDayGuid, Id= 1,  Protein = 10D, Carbohydrate = 10D, Fat = 10D,AllowedProtein=10,AllowedCarbohydrate=10,AllowedFat=10}
        // };
        // builder.HasKey(m => m.Id);
        //
        // builder.OwnsMany(m => m.Meals, meals =>
        // {
        //     meals.WithOwner().HasForeignKey("DayId");
        //     meals.HasData(foodAmounts);
        //     meals.OwnsMany(f => f.FoodAmounts, foodAmounts =>
        //     {
        //         foodAmounts.Property(m => m.Quantity)
        //             .IsRequired();
        //         foodAmounts.Property(m => m.FoodId)11
        //             .IsRequired();
        //         foodAmounts.HasData(new {MealDayId=newDayGuid, MealId= 1,Id=1,FoodId = 3, Quantity = 100D,Protein =10D, Carbohydrate=10D, Fat=10D});
        //     });
        // }).HasData(new {Id = newDayGuid, Date = DateOnly.FromDateTime(DateTime.Today), CreatedDate = DateTime.Now, Protein = 10D, Carbohydrate = 10D, Fat = 10D,AllowedProtein=100,AllowedCarbohydrate=100,AllowedFat=100,MealCount=1});

    }
}
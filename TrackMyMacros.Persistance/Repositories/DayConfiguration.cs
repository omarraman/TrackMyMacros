 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
 using TrackMyMacros.Domain.Aggregates.Day;

 namespace TrackMyMacros.Persistance.Repositories;

public class DayConfiguration : IEntityTypeConfiguration<Day>
{
    public void Configure(EntityTypeBuilder<Day> builder)
    {
        var newDayGuid = Guid.NewGuid();
        var foodAmounts = new List<object>()
        {
            new { DayId=newDayGuid, Id= 1,  Protein = 10D, Carbohydrate = 10D, Fat = 10D,AllowedProtein=10,AllowedCarbohydrate=10,AllowedFat=10}
        };
        builder.HasKey(m => m.Id);

        builder.OwnsMany(m => m.Meals, meals =>
        {
            meals.WithOwner().HasForeignKey("DayId");
            meals.HasData(foodAmounts);
            meals.OwnsMany(f => f.FoodAmounts, foodAmounts =>
            {
                foodAmounts.Property(m => m.Quantity)
                    .IsRequired();
                foodAmounts.Property(m => m.FoodId)
                    .IsRequired();
                foodAmounts.HasData(new {MealDayId=newDayGuid, MealId= 1,Id=1,FoodId = 3, Quantity = 100D,Protein =10D, Carbohydrate=10D, Fat=10D});
            });
        }).HasData(new {Id = newDayGuid, Date = DateOnly.FromDateTime(DateTime.Today), CreatedDate = DateTime.Now, Protein = 10D, Carbohydrate = 10D, Fat = 10D,AllowedProtein=100,AllowedCarbohydrate=100,AllowedFat=100,MealCount=1});
 
    }
}



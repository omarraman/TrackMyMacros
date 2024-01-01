 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
 using TrackMyMacros.Domain.Aggregates.Day;

 namespace TrackMyMacros.Persistance.Repositories;

public class DayConfiguration : IEntityTypeConfiguration<Day>
{
    public void Configure(EntityTypeBuilder<Day> builder)
    {
        var newDayGuid = Guid.NewGuid();
        var newMealGuid = Guid.NewGuid();
        var newFoodAmountGuid = Guid.NewGuid();
        
        // var foodAmounts = new List<object>()
        // {
        //     new { DayId=newGuid,Id=newGuid, Date1= DateOnly.FromDateTime(DateTime.Today) ,FoodId = 1, Quantity = 100 }
        // };
        var foodAmounts = new List<object>()
        {
            new { DayId=newDayGuid, Id= 1,  Protein = 10D, Carbohydrate = 10D, Fat = 10D}
        };
        // builder.HasData(new
        // {
        //     Id = newGuid,
        //     Date1 = DateOnly.FromDateTime(DateTime.Now),
        // });
        builder.HasKey(m => m.Id);
        // builder.Property(p => p.Date1)
        //     .IsRequired();

        builder.OwnsMany(m => m.Meals, meals =>
        {
            meals.WithOwner().HasForeignKey("DayId");
            // meals.Property<Guid>("Id");
            // meals.HasKey("DayId", "Id");
            meals.HasData(foodAmounts);
            // meals.HasData(new {DayId= newDayGuid, Id = newMealGuid, FoodAmounts = foodAmounts,  Protein = 10D, Carbohydrate = 10D, Fat = 10D});
            meals.OwnsMany(f => f.FoodAmounts, foodAmounts =>
            {
                foodAmounts.Property(m => m.Quantity)
                    .IsRequired();
                foodAmounts.Property(m => m.FoodId)
                    .IsRequired();
                foodAmounts.HasData(new {MealDayId=newDayGuid, MealId= 1,Id=1,FoodId = 1, Quantity = 100D,Protein =10D, Carbohydrate=10D, Fat=10D});
            });
        }).HasData(new {Id = newDayGuid, Date = DateOnly.FromDateTime(DateTime.Today), CreatedDate = DateTime.Now, Protein = 10D, Carbohydrate = 10D, Fat = 10D});
        // }).HasData(new {Id = newFoodAmountGuid,DayId = newDayGuid, MealId = newMealGuid,  Date = DateOnly.FromDateTime(DateTime.Today), CreatedDate = DateTime.Now, Protein = 10D, Carbohydrate = 10D, Fat = 10D});
        
        /*builder.OwnsOne(m => m.Meal, meals =>
        {
            meals.WithOwner().HasForeignKey("DayId");
            // meals.Property<Guid>("Id");
            // meals.HasKey("DayId", "Id");
            meals.Property(m => m.FoodId)
                .IsRequired();
            meals.OwnsMany(f => f.FoodAmounts, foodAmounts =>
            {
                foodAmounts.Property(m => m.Quantity)
                    .IsRequired();
                foodAmounts.Property(m => m.FoodId)
                    .IsRequired();
            });
        }).HasData(new { DayId=newGuid, FoodId = 1, Quantity = 100 });*/
    }
}


/*public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(m=>m.Id);
        builder.OwnsOne(m => m.Book, n =>
        {
            n.WithOwner().HasForeignKey("AuthorId");
        });
    }
}*/
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.Aggregates.Day;
using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Persistance.Repositories;

public class DayConfiguration : IEntityTypeConfiguration<Day>
{
    public void Configure(EntityTypeBuilder<Day> builder)
    {
        var newGuid = Guid.NewGuid();
        // var foodAmounts = new List<object>()
        // {
        //     new { DayId=newGuid,Id=newGuid, Date1= DateOnly.FromDateTime(DateTime.Today) ,FoodId = 1, Quantity = 100 }
        // };
        var foodAmounts = new List<object>()
        {
            new { DayId=newGuid, Id= 1,FoodId = 1, Quantity = 100 }
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
            meals.OwnsMany(f => f.FoodAmounts, foodAmounts =>
            {
                foodAmounts.Property(m => m.Quantity)
                    .IsRequired();
                foodAmounts.Property(m => m.FoodId)
                    .IsRequired();
                foodAmounts.HasData(new {MealDayId=newGuid, MealId= 1,Id=1,FoodId = 1, Quantity = 100D});
            });
        }).HasData(new {Id = newGuid, Date =DateTime.Today });
        
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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.Aggregates;

namespace TrackMyMacros.Persistance.Repositories;

public class FoodConfiguration : IEntityTypeConfiguration<Food>
{
    public void Configure(EntityTypeBuilder<Food> builder)
    {
        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.CarbohydrateAmount)
            .HasConversion(m=>m.Quantity,w=>new CarbohydrateAmount(w))
            .IsRequired();
        
        builder.Property(p => p.ProteinAmount)
            .HasConversion(m=>m.Quantity,w=>new ProteinAmount(w))
            .IsRequired();
        
        builder.Property(p => p.FatAmount)
            .HasConversion(m=>m.Quantity,w=>new FatAmount(w))
            .IsRequired();


        builder.Property(p => p.ProteinAmount).IsRequired();

        builder.Property(p => p.FatAmount ).IsRequired();

        builder.Property(p => p.Quantity).IsRequired();
        builder.Property(p => p.QuantityInGrams).IsRequired();
        builder.Property(p => p.UomId)
            .IsRequired();

        var readOnlyList = SeedData.Foods();
        builder.HasData(readOnlyList);
    }
}
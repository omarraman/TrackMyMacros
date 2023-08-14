using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMyMacros.Domain;

namespace TrackMyMacros.Persistance.Repositories;

public class UomConfiguration : IEntityTypeConfiguration<Uom>
{
    public void Configure(EntityTypeBuilder<Uom> builder)
    {
        builder.Property(p=>p.Id)
            .ValueGeneratedNever()
            .IsRequired();
        
        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(50);

        var readOnlyList = SeedData.Uoms();
        builder.HasData(readOnlyList);
    }
}
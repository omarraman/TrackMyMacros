using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMyMacros.Domain.Aggregates.Exercise;

namespace TrackMyMacros.Persistance.Repositories;

public class BodyPartConfiguration : IEntityTypeConfiguration<BodyPart>
{
    public void Configure(EntityTypeBuilder<BodyPart> builder)
    {
        builder.Property(p => p.Id)
            .IsRequired()
            .HasIdentityOptions(startValue: 50);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(p => p.Size)
            .HasConversion(p => p.Size
                , w => new BodyPartSize(w));

        var bodyParts = SeedExerciseData.GetBodyParts();
        builder.HasData(bodyParts);
    }
}
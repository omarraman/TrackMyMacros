using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMyMacros.Application.Features;

namespace TrackMyMacros.Persistance.Repositories;

public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
{
    public void Configure(EntityTypeBuilder<Exercise> builder)
    {
        builder.Property(p => p.Id)
            .IsRequired()
            .HasIdentityOptions(startValue: 50);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(30);
        
        builder.Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(p=>p.BodyPartId)
            .IsRequired();
        
        var exercises = SeedExerciseData.GetExercises();
        builder.HasData(exercises);
    }
}
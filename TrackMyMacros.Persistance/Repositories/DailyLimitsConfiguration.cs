﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMyMacros.Domain.Aggregates.DailyLimit;

namespace TrackMyMacros.Persistance.Repositories;

public class DailyLimitsConfiguration : IEntityTypeConfiguration<DailyLimits>
{
    public void Configure(EntityTypeBuilder<DailyLimits> builder)
    {
        builder.Property(p=>p.Id)
            .ValueGeneratedNever()
            .IsRequired();

        builder.HasData(
            new DailyLimits(2400, 75.9, 5, 5));


        ;
    }
}
using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.Aggregates;
using TrackMyMacros.Domain.Aggregates.DailyLimit;
using TrackMyMacros.Domain.Aggregates.Day;
using TrackMyMacros.Domain.Aggregates.FoodCombo;

namespace TrackMyMacros.Persistance;

public class AppDbContext:DbContext
{
    public DbSet<Food> Food { get; set; }
    public DbSet<Uom> Uoms { get; set; }
    public DbSet<Day> Days { get; set; }
    public DbSet<DailyLimits> DailyLimits { get; set; }
    public DbSet<FoodCombo> FoodCombos { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine);
        base.OnConfiguring(optionsBuilder);
    }
}
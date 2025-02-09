using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

namespace TrackMyMacros.Persistance;

public static class DbInitializer
{
    public static void InitializeMesocycles(AppDbContext context)
    {
        context.Database.EnsureCreated();
        Guid mesoId = Guid.NewGuid();
        context.SaveChanges();
    }
}
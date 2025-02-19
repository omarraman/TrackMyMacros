using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Persistance.Repositories;

namespace TrackMyMacros.Persistance;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.EnableDetailedErrors()  
                .EnableSensitiveDataLogging()
                .UseNpgsql(configuration.GetConnectionString("MacrosConnectionString")));

        services.AddScoped<IFoodRepository, FoodRepository>();
        services.AddScoped<IMealRepository, MealRepository>();
        services.AddScoped<IUomRepository, UomRepository>();
        services.AddScoped<IDayRepository, DayRepository>();
        services.AddScoped<IDailyLimitsRepository, DailyLimitsRepository>();
        services.AddScoped<IFoodComboRepository, FoodComboRepository>();
        services.AddScoped<IWeightReadingRepository, WeightReadingRepository>();
        services.AddScoped<IRecipeRepository, RecipeRepository>();
        services.AddScoped<IMesocycleRepository, MesocycleRepository>();
        services.AddScoped<IExerciseRepository, ExerciseRepository>();
        return services;    
    }
}
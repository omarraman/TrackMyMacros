using TrackMyMacros.Domain.Aggregates;
using TrackMyMacros.Domain.Aggregates.Recipe;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

//add this to PersistenceServiceRegistration
//services.AddScoped<IWeightReadingRepository, WeightReadingRepository>();
//add this to AppDbContext
//public DbSet<WeightReading> WeightReadings { get; set; }
namespace TrackMyMacros.Persistance.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private AppDbContext _dbContext;
        public RecipeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<Maybe<Recipe>> GetByIdAsync(Guid id)
        {
            var set = _dbContext.Set<Recipe>();
            var findAsync = await set.FindAsync(id);
            return findAsync ?? Maybe<Recipe>.None;
        }

        public async Task<IReadOnlyList<Recipe>> ListAllAsync()
        {
            var results = await _dbContext.Set<Recipe>().AsNoTracking().ToListAsync();
            if (!results.Any())
                return new List<Recipe>();
            return results;
        }

        public async virtual Task<IReadOnlyList<Recipe>> GetPagedReponseAsync(int page, int size)
        {
            return await _dbContext.Set<Recipe>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<Recipe> AddAsync(Recipe entity)
        {
            await _dbContext.Set<Recipe>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<Result> UpdateAsync(Recipe entity)
        {
            var recipe = await _dbContext.Set<Recipe>().FindAsync(entity.Id);
            _dbContext.Entry(recipe).CurrentValues.SetValues(entity);
            recipe.RecipeFoodAmounts.Clear();
            foreach (var recipeAmount in entity.RecipeFoodAmounts)
            {
                recipe.RecipeFoodAmounts.Add(recipeAmount);    
            }
            await _dbContext.SaveChangesAsync();
            return new SuccessResult();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _dbContext.Set<Recipe>().FindAsync(id);
            _dbContext.Set<Recipe>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }

    // public interface IRecipeRepository
    // {
    //     Task<Maybe<Recipe>> GetByIdAsync(Guid id);
    //     Task<IReadOnlyList<Recipe>> ListAllAsync();
    //     Task<IReadOnlyList<Recipe>> GetPagedReponseAsync(int page, int size);
    //     Task<Recipe> AddAsync(Recipe entity);
    //     Task<Result> UpdateAsync(Recipe entity);
    //     Task DeleteAsync(Guid id);
    // }
}
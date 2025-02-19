using TrackMyMacros.Domain.Aggregates;
using TrackMyMacros.Domain.Aggregates.Recipe;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.ValueObjects;
using TrackMyMacros.SharedKernel;

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

        public async Task<Recipe> AddAsync(Recipe recipe)
        {
            await _dbContext.Set<Recipe>().AddAsync(recipe);
            await _dbContext.SaveChangesAsync();
            return recipe;
        }

        public async Task<Recipe> AddAsync(Recipe recipe,Food food)
        {
            await _dbContext.Set<Recipe>().AddAsync(recipe);
            await _dbContext.Set<Food>().AddAsync(food);
            await _dbContext.SaveChangesAsync();
            return recipe;
        }
        //
        public async Task<Result> UpdateAsync(Recipe entity)
        {
            var recipe = await _dbContext.Set<Recipe>().FindAsync(entity.Id);
            _dbContext.Entry(recipe).CurrentValues.SetValues(entity);
            recipe.RecipeFoodAmounts.Clear();
            foreach (var recipeAmount in entity.RecipeFoodAmounts)
            {
                recipe.RecipeFoodAmounts.Add(recipeAmount);    
            }

            var food = await _dbContext.Food.SingleOrDefaultAsync(f => f.RecipeId == entity.Id);
            if (food==null)
            {
                throw new Exception("Could not update recipe - reason: linked food not found");
            }
            food.CarbohydrateAmount = new CarbohydrateAmount(recipe.CarbohydratePer100G);
            food.FatAmount = new FatAmount(recipe.FatPer100G);
            food.ProteinAmount = new ProteinAmount(recipe.ProteinPer100G);
            food.Name=recipe.Name + "(R)";
            food.Quantity = 100;
            food.RecipeId = recipe.Id;
            food.UomId = 1;
            await _dbContext.SaveChangesAsync();
            return new SuccessResult();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _dbContext.Set<Recipe>().FindAsync(id);
            var food = await _dbContext.Food.SingleOrDefaultAsync(f => f.RecipeId == entity.Id);
            if (food==null)
            {
                throw new Exception("Could not update recipe - reason: linked food not found");
            }
            _dbContext.Set<Recipe>().Remove(entity);
            _dbContext.Set<Food>().Remove(food);
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
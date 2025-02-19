
using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Domain.Aggregates;
using TrackMyMacros.Domain.Aggregates.FoodCombo;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Persistance.Repositories;

public class FoodComboRepository : IFoodComboRepository
{
        protected readonly AppDbContext _dbContext;

        public FoodComboRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<Maybe<FoodCombo>> GetByIdAsync(Guid id)
        {
            var set = _dbContext.Set<FoodCombo>();
            var findAsync = await set.FindAsync(id);
            return findAsync ?? Maybe<FoodCombo>.None;
        }

        public async Task<IReadOnlyList<FoodCombo>> ListAllAsync()
        {
            var results = await _dbContext.Set<FoodCombo>().AsNoTracking().ToListAsync();
            if (!results.Any())
                return new List<FoodCombo>();
            
            return results;
        }

        public async virtual Task<IReadOnlyList<FoodCombo>> GetPagedReponseAsync(int page, int size)
        {
            return await _dbContext.Set<FoodCombo>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<FoodCombo> AddAsync(FoodCombo entity)
        {
            await _dbContext.Set<FoodCombo>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Result> UpdateAsync(FoodCombo entity)
        {

            var foodInDb= await _dbContext.Set<FoodCombo>().FindAsync(entity.Id);
            _dbContext.Entry(foodInDb).CurrentValues.SetValues(entity);

            foodInDb.FoodComboAmounts.Clear();
            
            foreach (var foodComboAmount in entity.FoodComboAmounts)
            {
                foodInDb.FoodComboAmounts.Add(foodComboAmount);    
            }
            
            await _dbContext.SaveChangesAsync();

            return new SuccessResult();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _dbContext.Set<FoodCombo>().FindAsync(id);
            _dbContext.Set<FoodCombo>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
}


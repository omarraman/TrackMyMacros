
using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Domain.Aggregates;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.Persistance.Repositories;

public class FoodRepository:IFoodRepository
{
        protected readonly AppDbContext _dbContext;

        public FoodRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<Maybe<Food>> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Food>().FindAsync(id) ?? Maybe<Food>.None;
        }

        public async Task<IReadOnlyList<Food>> ListAllAsync()
        {
            return await _dbContext.Set<Food>().ToListAsync();
        }

        public async virtual Task<IReadOnlyList<Food>> GetPagedReponseAsync(int page, int size)
        {
            return await _dbContext.Set<Food>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<Food> AddAsync(Food entity)
        {
            await _dbContext.Set<Food>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Result> UpdateAsync(Food entity)
        {
            var foodInDb= await _dbContext.Set<Food>().FindAsync(entity.Id);
            _dbContext.Entry(foodInDb).CurrentValues.SetValues(entity);
            var updatedCount =await _dbContext.SaveChangesAsync();
            if (updatedCount == 0)
            {
                throw new Exception("Failed to update food");
            }

            return new SuccessResult();
        }

        public async Task DeleteAsync(Food entity)
        {
            _dbContext.Set<Food>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
}
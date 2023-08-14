using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Domain;

namespace TrackMyMacros.Persistance.Repositories;

public class FoodRepository:IFoodRepository
{
        protected readonly AppDbContext _dbContext;

        public FoodRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<Maybe<Food>> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<Food>().FindAsync(id);
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

        public async Task UpdateAsync(Food entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Food entity)
        {
            _dbContext.Set<Food>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
}
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.Aggregates.Day;

namespace TrackMyMacros.Persistance.Repositories;

public class DayRepository:IDayRepository
{
        protected readonly AppDbContext _dbContext;

        public DayRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<Maybe<Day>> GetByDateAsync(DateTime date)
        {
            var y = _dbContext.Set<Day>().AsNoTracking().ToList();
            var x =  await _dbContext.Set<Day>()
                .AsNoTracking().SingleOrDefaultAsync(m=>m.Date.Date==date.Date);
            return x;
        }

        /*public async Task<IReadOnlyList<Food>> ListAllAsync()
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
        }*/
}

using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Domain.Aggregates.DailyLimit;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Persistance.Repositories;

public class DailyLimitsRepository:IDailyLimitsRepository
{
        protected readonly AppDbContext _dbContext;

        public DailyLimitsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<Maybe<DailyLimits>> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<DailyLimits>().FindAsync(id);
        }

        public async Task<IReadOnlyList<DailyLimits>> ListAllAsync()
        {
            return await _dbContext.Set<DailyLimits>().ToListAsync();
        }

        public async virtual Task<IReadOnlyList<DailyLimits>> GetPagedReponseAsync(int page, int size)
        {
            return await _dbContext.Set<DailyLimits>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<DailyLimits> AddAsync(DailyLimits entity)
        {
            entity.Id = new Guid();
            await _dbContext.Set<DailyLimits>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync(DailyLimits entity)
        {
            var first = await _dbContext.Set<DailyLimits>().FirstOrDefaultAsync();
            if (first!=null)
            {
                _dbContext.Set<DailyLimits>().Remove(first);
            }
            entity.Id = new Guid();
            await _dbContext.Set<DailyLimits>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(DailyLimits entity)
        {
            _dbContext.Set<DailyLimits>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
}
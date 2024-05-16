
using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Domain.Aggregates;
using TrackMyMacros.Domain.Aggregates.WeightReading;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.Persistance.Repositories;

public class WeightReadingRepository : IWeightReadingRepository
{
        protected readonly AppDbContext _dbContext;

        public WeightReadingRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<Maybe<WeightReading>> GetByIdAsync(Guid id)
        {
            var set = _dbContext.Set<WeightReading>();
            var findAsync = await set.FindAsync(id);
            return findAsync ?? Maybe<WeightReading>.None;
        }

        public async Task<IReadOnlyList<WeightReading>> ListAllAsync()
        {
            var results = await _dbContext.Set<WeightReading>().AsNoTracking().ToListAsync();
            if (!results.Any())
                return new List<WeightReading>();
            
            return results;
        }

        public async virtual Task<IReadOnlyList<WeightReading>> GetPagedReponseAsync(int page, int size)
        {
            return await _dbContext.Set<WeightReading>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<WeightReading> AddAsync(WeightReading entity)
        {
            await _dbContext.Set<WeightReading>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Result> UpdateAsync(WeightReading entity)
        {

            var foodInDb= await _dbContext.Set<WeightReading>().FindAsync(entity.Id);
            _dbContext.Entry(foodInDb).CurrentValues.SetValues(entity);

            await _dbContext.SaveChangesAsync();

            return new SuccessResult();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _dbContext.Set<WeightReading>().FindAsync(id);
            _dbContext.Set<WeightReading>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
}


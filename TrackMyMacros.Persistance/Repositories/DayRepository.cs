
using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Domain.Aggregates.Day;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Persistance.Repositories;

public class DayRepository:IDayRepository
{
        protected readonly AppDbContext _dbContext;

        public DayRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<Maybe<Day>> GetByDateAsync(DateOnly date)
        {
            var x =  await _dbContext.Set<Day>()
                .AsNoTracking().SingleOrDefaultAsync(m=>m.Date==date);
            return x;
        }

//         /*public async Task<IReadOnlyList<Food>> ListAllAsync()
//         {
//             return await _dbContext.Set<Food>().ToListAsync();
//         }
//
//         public async virtual Task<IReadOnlyList<Food>> GetPagedReponseAsync(int page, int size)
//         {
//             return await _dbContext.Set<Food>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
//         }
//
//         public async Task<Food> AddAsync(Food entity)
//         {
//             await _dbContext.Set<Food>().AddAsync(entity);
//             await _dbContext.SaveChangesAsync();
//
//             return entity;
//         }
//
         public async Task UpdateAsync(Day dayToAdd)
         {
             var dayToRemove=_dbContext.Days.SingleOrDefault(m => m.Date == dayToAdd.Date);
             if (dayToRemove!=default)
             {
                 _dbContext.Days.Remove(dayToRemove);
                 _dbContext.Days.Add(dayToAdd);
             }
             else
             {
                 _dbContext.Days.Add(dayToAdd);
             }
             await _dbContext.SaveChangesAsync();
         }
//
//         public async Task DeleteAsync(Food entity)
//         {
//             _dbContext.Set<Food>().Remove(entity);
//             await _dbContext.SaveChangesAsync();
//         }*/
}
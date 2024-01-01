
using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Domain;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.Persistance.Repositories;

public class UomRepository:IUomRepository
{
        protected readonly AppDbContext _dbContext;

        public UomRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<Maybe<Uom>> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<Uom>().FindAsync(id);
        }

        public async Task<IReadOnlyList<Uom>> ListAllAsync()
        {
            return await _dbContext.Set<Uom>().ToListAsync();
        }

        public async virtual Task<IReadOnlyList<Uom>> GetPagedReponseAsync(int page, int size)
        {
            return await _dbContext.Set<Uom>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
        }

        public async Task<Uom> AddAsync(Uom entity)
        {
            await _dbContext.Set<Uom>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync(Uom entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Uom entity)
        {
            _dbContext.Set<Uom>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
}
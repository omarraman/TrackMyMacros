using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.Aggregates.Day;

namespace TrackMyMacros.Persistance.Repositories;


public class MealRepository:IMealRepository
{
    protected readonly AppDbContext _dbContext;

    public MealRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual async Task<Maybe<Meal>> GetByIdAsync(Guid id)
    {
        return await _dbContext.Set<Meal>().FindAsync(id);
    }

    public async Task<IReadOnlyList<Meal>> ListAllAsync()
    {
        return await _dbContext.Set<Meal>().ToListAsync();
    }

    public async virtual Task<IReadOnlyList<Meal>> GetPagedReponseAsync(int page, int size)
    {
        return await _dbContext.Set<Meal>().Skip((page - 1) * size).Take(size).AsNoTracking().ToListAsync();
    }

    public async Task<Meal> AddAsync(Meal entity)
    {
        await _dbContext.Set<Meal>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    public async Task UpdateAsync(Meal entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Meal entity)
    {
        _dbContext.Set<Meal>().Remove(entity);
        await _dbContext.SaveChangesAsync();
    }
}
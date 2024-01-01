using TrackMyMacros.Domain.Aggregates.Day;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.Application.Contracts.Persistence;

public interface IMealRepository
{
    Task<Maybe<Meal>> GetByIdAsync(Guid id);

    Task<IReadOnlyList<Meal>> ListAllAsync();
    Task<Meal> AddAsync(Meal entity);
    Task UpdateAsync(Meal entity);
    Task DeleteAsync(Meal entity);
    Task<IReadOnlyList<Meal>> GetPagedReponseAsync(int page, int size);
}
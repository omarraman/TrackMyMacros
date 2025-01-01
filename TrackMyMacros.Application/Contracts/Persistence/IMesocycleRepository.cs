using TrackMyMacros.Domain.Aggregates.Exercise;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.Application.Contracts.Persistence;

public interface IMesocycleRepository
{
    Task<Maybe<Mesocycle>> GetByIdAsync(Guid id);
    Task<IReadOnlyList<Mesocycle>> ListAllAsync();
    Task<IReadOnlyList<Mesocycle>> GetPagedReponseAsync(int page, int size);
    Task<Mesocycle> AddAsync(Mesocycle entity);
    Task<Result> UpdateAsync(Mesocycle entity);
    Task DeleteAsync(Guid id);
}
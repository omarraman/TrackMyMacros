using TrackMyMacros.Domain.Aggregates.WeightReading;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.Application.Contracts.Persistence;

public interface IWeightReadingRepository
{
    Task<Maybe<WeightReading>> GetByIdAsync(Guid id);
    Task<IReadOnlyList<WeightReading>> ListAllAsync();
    Task<IReadOnlyList<WeightReading>> GetPagedReponseAsync(int page, int size);
    Task<WeightReading> AddAsync(WeightReading entity);
    Task<Result> UpdateAsync(WeightReading entity);
    Task DeleteAsync(Guid id);
}
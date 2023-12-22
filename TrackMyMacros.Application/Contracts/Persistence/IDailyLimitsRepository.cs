using CSharpFunctionalExtensions;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.Aggregates.DailyLimit;

namespace TrackMyMacros.Application.Contracts.Persistence;

public interface IDailyLimitsRepository
{
    Task<Maybe<DailyLimits>> GetByIdAsync(Guid id);
    Task<IReadOnlyList<DailyLimits>> ListAllAsync();
    Task<DailyLimits> AddAsync(DailyLimits entity);
    Task UpdateAsync(DailyLimits entity);
    Task DeleteAsync(DailyLimits entity);
}

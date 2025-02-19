
using TrackMyMacros.Domain.Aggregates.Day;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Contracts.Persistence;

public interface IDayRepository
{
    Task<Maybe<Day>> GetByDateAsync(DateOnly date);
    Task UpdateAsync(Day day);
}
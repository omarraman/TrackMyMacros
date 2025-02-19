using TrackMyMacros.Domain.Aggregates.Exercise;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Contracts.Persistence;

public interface IExerciseRepository
{
    Task<Maybe<Exercise>> GetByIdAsync(Guid id);
    Task<IReadOnlyList<Exercise>> ListAllAsync();
    Task<IReadOnlyList<Exercise>> GetPagedReponseAsync(int page, int size);
    Task<Exercise> AddAsync(Exercise entity);
    Task<Result> UpdateAsync(Exercise entity);
    Task DeleteAsync(Guid id);
}
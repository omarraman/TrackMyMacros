using CSharpFunctionalExtensions;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.Aggregates;

namespace TrackMyMacros.Application.Contracts.Persistence;

public interface IFoodRepository
{
    Task<Maybe<Food>> GetByIdAsync(int id);
    Task<IReadOnlyList<Food>> ListAllAsync();
    Task<Food> AddAsync(Food entity);
    Task<Result> UpdateAsync(Food entity);
    Task DeleteAsync(Food entity);
    Task<IReadOnlyList<Food>> GetPagedReponseAsync(int page, int size);
}

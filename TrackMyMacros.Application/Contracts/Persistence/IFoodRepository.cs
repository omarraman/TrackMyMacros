using CSharpFunctionalExtensions;
using TrackMyMacros.Domain;

namespace TrackMyMacros.Application.Contracts.Persistence;

public interface IFoodRepository
{
    Task<Maybe<Food>> GetByIdAsync(Guid id);
    Task<IReadOnlyList<Food>> ListAllAsync();
    Task<Food> AddAsync(Food entity);
    Task UpdateAsync(Food entity);
    Task DeleteAsync(Food entity);
    Task<IReadOnlyList<Food>> GetPagedReponseAsync(int page, int size);
}

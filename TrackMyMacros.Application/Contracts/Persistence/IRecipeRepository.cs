using TrackMyMacros.Domain.Aggregates;
using TrackMyMacros.Domain.Aggregates.Recipe;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.Application.Contracts.Persistence;


public interface IRecipeRepository
{
    Task<Maybe<Recipe>> GetByIdAsync(Guid id);
    Task<IReadOnlyList<Recipe>> ListAllAsync();
    Task<IReadOnlyList<Recipe>> GetPagedReponseAsync(int page, int size);
    Task<Recipe> AddAsync(Recipe recipe);
    Task<Recipe> AddAsync(Recipe recipe, Food food);
    Task<Result> UpdateAsync(Recipe entity);
    Task DeleteAsync(Guid id);
}
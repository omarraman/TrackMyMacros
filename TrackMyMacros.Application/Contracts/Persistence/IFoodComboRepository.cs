using TrackMyMacros.Domain.Aggregates.FoodCombo;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.Application.Contracts.Persistence;

public interface IFoodComboRepository
{
    Task<Maybe<FoodCombo>> GetByIdAsync(Guid id);
    Task<IReadOnlyList<FoodCombo>> ListAllAsync();
    Task<IReadOnlyList<FoodCombo>> GetPagedReponseAsync(int page, int size);
    Task<FoodCombo> AddAsync(FoodCombo entity);
    Task<Result> UpdateAsync(FoodCombo entity);
    Task DeleteAsync(Guid id);
}
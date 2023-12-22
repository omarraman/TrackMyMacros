using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Interfaces;

public interface IFoodDataService
{
    Task<IReadOnlyList<FoodListItemViewModel>> GetFoods( );
    Task AddFood(CreateFoodViewModel dto);
    Task UpdateFood(FoodListItemViewModel model);
}
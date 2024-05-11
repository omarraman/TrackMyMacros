using TrackMyMacros.App3.ViewModels;

namespace TrackMyMacros.App3.Interfaces;

public interface IFoodDataService
{
    Task<IReadOnlyList<FoodListItemViewModel>> GetFoods( );
    Task AddFood(CreateFoodViewModel dto);
    Task UpdateFood(FoodListItemViewModel model);
}
using TrackMyMacros.App4.ViewModels;

namespace TrackMyMacros.App4.Interfaces
{
    public interface IFoodDataService
    {
        Task<IReadOnlyList<FoodListItemViewModel>> GetFoods( );
        Task AddFood(CreateFoodViewModel dto);
        Task UpdateFood(FoodListItemViewModel model);
    }
}
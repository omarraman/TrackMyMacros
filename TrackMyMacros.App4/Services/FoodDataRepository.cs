using TrackMyMacros.App4.Interfaces;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.Services
{
    public interface IFoodDataRepository
    {
        Task Refresh();
        // IReadOnlyList<FoodListItemViewModel> FoodList { get; }
        Maybe<FoodListItemViewModel> GetFood(int id);
        Task<IReadOnlyList<FoodListItemViewModel>> GetFoodList();
    }

    public class FoodDataRepository : IFoodDataRepository
    {
        private readonly IFoodDataService _foodDataService;
        private bool _loaded;

        public async Task<IReadOnlyList<FoodListItemViewModel>> GetFoodList()
        {
            if (!_loaded)
            {
                await Refresh();
            }

            return FoodList;
        }

        private IReadOnlyList<FoodListItemViewModel> FoodList
        {
            get;
            set;
        }

    

        // public IReadOnlyList<FoodListItemViewModel> FoodList
        // {
        //     get
        //     {
        //         if (!_loaded)
        //         {
        //             Refresh();
        //         }
        //
        //         return _foodList;
        //     }
        //     private set => _foodList = value;
        // }

        public FoodDataRepository(IFoodDataService foodDataService)
        {
            _foodDataService = foodDataService;
        }

        public async Task Refresh()
        {
            var list = new List<FoodListItemViewModel>();
            list.Add(new FoodListItemViewModel
            {
                Id = -1,
                Name = "Nothing selected"
            });
            list.AddRange(await _foodDataService.GetFoods());
            FoodList = list;
            _loaded = true;
        }


        public Maybe<FoodListItemViewModel> GetFood(int id)
        {
            var foodListItem = FoodList.FirstOrDefault(m => m.Id == id);
            if (foodListItem == null)
            {
                return Maybe<FoodListItemViewModel>.None;
            }

            return foodListItem;
        }
    }
}
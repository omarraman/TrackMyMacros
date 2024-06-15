using AutoMapper;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Radzen;
using TrackMyMacros.App4.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModels.Recipe;
using TrackMyMacros.Dtos.Recipe;


/*
                filename will be RecipeList.razor

                @page "/RecipeList"


                @if (Recipes != null)
                {
                    @foreach (var RecipeViewModel in Recipes)
                    {
                        <div>
                            @RecipeViewModel.Date @RecipeViewModel.Weight
                            <RadzenButton Text="Edit" ButtonStyle="ButtonStyle.Primary" Click="()=>Edit(RecipeViewModel.Id)"/>
                            <RadzenButton Text="Delete" ButtonStyle="ButtonStyle.Primary" Click="()=>Delete(RecipeViewModel.Id)"/>
                        </div>
                    }
                }
                else
                {
                    <div>Loading...</div>
                }

*/
                
namespace TrackMyMacros.App4.Pages
{
    public partial class RecipeList
    {
        protected override async Task OnInitializedAsync()
        {
            await Refresh();
        }

        private async Task Refresh()
        {
            var temp = await _dataService.GetList<GetRecipeViewModel, GetRecipeDto>(GenericDataService.Endpoints.Recipe);
            // Recipes = temp.OrderByDescending(m => m.Date).ToList();
        }

        private async void Edit(Guid id)
        {
            var viewModel = await _dataService.Get<UpdateRecipeViewModel, GetRecipeDto>($"{GenericDataService.Endpoints.Recipe}/GetById/{id}");
            var json = JsonConvert.SerializeObject(viewModel);
            var viewModelCopy = JsonConvert.DeserializeObject<UpdateRecipeViewModel>(json);
            await DialogService.OpenAsync<AddOrUpdateRecipeDialog>("Edit Recipe", new Dictionary<string, object> { { "Recipe", viewModelCopy }, { "DialogService", DialogService }, { "EditMode", true }, { "Id", id }, { "OnDialogClose", EventCallback.Factory.Create(this, OnDialogClose) } });
        }

        private async void Delete(Guid id)
        {
            await _dataService.Delete($"{GenericDataService.Endpoints.Recipe}/{id}");
            await Refresh();
            StateHasChanged();
        }

        private async Task OnDialogClose()
        {
            await Refresh();
            StateHasChanged();
        }

        [Inject]
        public IGenericDataService _dataService { get; set; }

        [Inject]
        public DialogService DialogService { get; set; }

        [Inject]
        public IMapper Mapper { get; set; }
        public IReadOnlyList<GetRecipeViewModel> Recipes { get; set; }
    }
}
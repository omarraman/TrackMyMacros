using AutoMapper;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Radzen;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModels.Mesocycle;
using TrackMyMacros.Dtos.Mesocycle;


namespace TrackMyMacros.App4.Pages
{
    public partial class MesocycleList
    {
        [Inject] public NavigationManager NavigationManager { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Refresh();
        }

        private async Task Refresh()
        {
            var temp = await _dataService.GetList<GetMesocycleViewModel, GetMesocycleDto>(GenericDataService.Endpoints
                .Mesocycle);
            Mesocycles = temp.Where(model => model.IsTemplate).ToList();
        }

        private async void Edit(Guid id)
        {
            NavigationManager.NavigateTo($"/AddMesocycleTemplate/{id}");
            
        }

        private async void Delete(Guid id)
        {
            await _dataService.Delete($"{GenericDataService.Endpoints.Mesocycle}/{id}");
            await Refresh();
            StateHasChanged();
        }

        private async Task OnDialogClose()
        {
            await Refresh();
            StateHasChanged();
        }

        [Inject] public IGenericDataService _dataService { get; set; }

        [Inject] public DialogService DialogService { get; set; }

        [Inject] public IMapper Mapper { get; set; }
        public IReadOnlyList<GetMesocycleViewModel> Mesocycles { get; set; }
    }
}
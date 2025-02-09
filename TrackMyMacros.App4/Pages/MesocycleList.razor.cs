using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.Dtos.Mesocycle;


/*
                filename will be MesocycleList.razor

                @page "/MesocycleList"


                @if (Mesocycles != null)
                {
                    @foreach (var MesocycleViewModel in Mesocycles)
                    {
                        <div>
                            @MesocycleViewModel.Date @MesocycleViewModel.Weight
                            <RadzenButton Text="Edit" ButtonStyle="ButtonStyle.Primary" Click="()=>Edit(MesocycleViewModel.Id)"/>
                            <RadzenButton Text="Delete" ButtonStyle="ButtonStyle.Primary" Click="()=>Delete(MesocycleViewModel.Id)"/>
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
    public partial class MesocycleList
    {
        protected override async Task OnInitializedAsync()
        {
            await Refresh();
        }

        private async Task Refresh()
        {
            var temp = await _dataService.GetList<GetMesocycleViewModel, GetMesocycleDto>(GenericDataService.Endpoints.Mesocycle);
            Mesocycles = temp.OrderByDescending(m => m.Date).ToList();
        }

        private async void Edit(Guid id)
        {
            //note the parameters must match the parameters in the dialog, otherwise you get a blank dialog
            var viewModel = await _dataService.Get<GetMesocycleViewModel, GetMesocycleDto>($"{GenericDataService.Endpoints.Mesocycle}/GetById/{id}");
            var json = JsonConvert.SerializeObject(viewModel);
            var viewModelCopy = JsonConvert.DeserializeObject<UpdateMesocycleViewModel>(json);
            await DialogService.OpenAsync<AddOrUpdateMesocycleDialog>("Edit Mesocycle", new Dictionary<string, object> { { "Mesocycle", viewModelCopy }, { "DialogService", DialogService }, { "EditMode", true }, { "Id", id }, { "OnDialogClose", EventCallback.Factory.Create(this, OnDialogClose) } });
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

        [Inject]
        public IGenericDataService _dataService { get; set; }

        [Inject]
        public DialogService DialogService { get; set; }

        [Inject]
        public IMapper Mapper { get; set; }
        public IReadOnlyList<GetMesocycleViewModel> Mesocycles { get; set; }
    }
}
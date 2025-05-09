using System.Text.Json;
using AutoMapper;
using Microsoft.AspNetCore.Components;
using Radzen;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels.Mesocycle;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.SharedKernel;


namespace TrackMyMacros.App4.Pages
{
    public partial class MesocycleList
    {
        [Inject] public NavigationManager NavigationManager { get; set; }

        public bool ShowTemplates { get; set; } = true;


        protected override async Task OnInitializedAsync()
        {
            await Refresh();
        }

        private async Task Refresh()
        {
            var temp = await _dataService.GetList<GetMesocycleViewModel, GetMesocycleDto>(GenericDataService.Endpoints
                .Mesocycle);
            Mesocycles = temp.Where(model => model.IsTemplate == ShowTemplates).ToList();
        }

        private async Task OnChange(bool newValue)
        {
            ShowTemplates = newValue;
            await Refresh();
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

        private void OnSetMesocycleComplete(Guid id, bool complete)
        {
            var mesocycle = Mesocycles.Single(m => m.Id == id);
            mesocycle.Complete = complete;
            var updateMesocycleViewModel= Mapper.Map<UpdateMesocycleViewModel>(mesocycle);
            _dataService.Put<UpdateMesocycleViewModel, UpdateMesocycleDto>(Endpoint.Mesocycle, updateMesocycleViewModel);
        }

        private void OnSetMesocycleActive(Guid id, bool active)
        {
            var mesocycle = Mesocycles.Single(m => m.Id == id);
            //mesocycle.Active = active;
            var updateMesocycleViewModel= Mapper.Map<UpdateMesocycleViewModel>(mesocycle);
            _dataService.Put<UpdateMesocycleViewModel, UpdateMesocycleDto>(Endpoint.Mesocycle, updateMesocycleViewModel);
        }
        
        private async void Clone(Guid id)
        {
            var mesocycleToClone = Mesocycles.FirstOrDefault(m => m.Id == id);

            var options = new JsonSerializerOptions();
            options.Converters.Add(new MyDayOfWeekConverter());

            var json = JsonSerializer.Serialize(mesocycleToClone, options);
            var clone = JsonSerializer.Deserialize<GetMesocycleViewModel>(json, options);

            clone!.IsTemplate = false;
            var firstDayOfWeek = clone.Weeks.First().Workouts.First().DayOfWeek;
            clone.CurrentDayOfWeek = firstDayOfWeek;

            clone.Name = $"{mesocycleToClone.Name} - {DateTime.Now.ToString("yyyy-MM-dd")}";

            var createMesocycleViewModel = Mapper.Map<CreateMesocycleViewModel>(clone);
            createMesocycleViewModel.Complete = false;

            
            await _dataService.Post<CreateMesocycleViewModel, CreateMesocycleDto>(createMesocycleViewModel,
                GenericDataService.Endpoints.Mesocycle);
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
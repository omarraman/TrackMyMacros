using AutoMapper;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Radzen;
using TrackMyMacros.App4.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModelsWeightReading;
using TrackMyMacros.Dtos.WeightReading;
using TrackMyMacros.Dtos.WeightReading;

namespace TrackMyMacros.App4.Pages;

public partial class WeightReadingList
{
    [Inject] public IGenericDataService _dataService { get; set; }

    [Inject] public DialogService DialogService { get; set; }
    [Inject] public IMapper Mapper { get; set; }

    public IReadOnlyList<GetWeightReadingViewModel> WeightReadings { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await Refresh();
    }

    private async Task Refresh()
    {
        var temp = await _dataService.GetList<GetWeightReadingViewModel, GetWeightReadingDto>(GenericDataService
            .Endpoints.WeightReading);
        WeightReadings = temp.OrderByDescending(m => m.Date).ToList();
    }

    private async void Edit(Guid id)
    {
        var viewModel =
            await _dataService.Get<GetWeightReadingViewModel, GetWeightReadingDto>(
                $"{GenericDataService.Endpoints.WeightReading}/GetById/{id}");
        var json = JsonConvert.SerializeObject(viewModel);
        var viewModelCopy = JsonConvert.DeserializeObject<WeightReadingViewModel>(json);
        await DialogService.OpenAsync<AddOrUpdateWeightReadingDialog>("Edit WeightReading",
            new Dictionary<string, object>
            {
                { "WeightReading", viewModelCopy },
                { "DialogService", DialogService },
                { "EditMode", true },
                { "Id", id },
                { "OnDialogClose", EventCallback.Factory.Create(this, OnDialogClose) }
            });
    }

    private async void Delete(Guid id)
    {
        await _dataService.Delete($"{GenericDataService.Endpoints.WeightReading}/{id}");
        await Refresh();
        StateHasChanged();
    }

    private async Task OnDialogClose()
    {
        await Refresh();
        StateHasChanged();
    }
}
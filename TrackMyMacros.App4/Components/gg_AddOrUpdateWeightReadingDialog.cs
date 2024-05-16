using AutoMapper;
using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;
using Radzen;
using TrackMyMacros.Dtos;
using TrackMyMacros.Dtos.WeightReading;

namespace TrackMyMacros.App4.Components
{
    public partial class AddOrUpdateWeightReadingDialog
    {
        [Parameter]
        public DialogService DialogService { get; set; }

        [Parameter]
        public WeightReadingViewModel WeightReading { get; set; }

        [Parameter]
        public EventCallback OnDialogClose { get; set; }

        [Inject]
        public IGenericDataService _foodComboDataService { get; set; }

        [Inject]
        public IMapper Mapper { get; set; }

        [Parameter]
        public string WeightReadingName { get; set; }

        [Parameter]
        public Guid Id { get; set; }

        [Parameter]
        public bool EditMode { get; set; } = false;

        public async Task SaveAndClose()
        {
            // if (EditMode)
            // {
            //     await _foodComboDataService.Put<>(WeightReading, WeightReadingName, Id);
            // }
            // else
            // {
            //     await _foodComboDataService.CreateWeightReadingCombo(WeightReading, WeightReadingName);
            // }

            await OnDialogClose.InvokeAsync();
            DialogService.Close();
        }

        public void CancelClicked()
        {
            DialogService.Close();
        }
    }
}
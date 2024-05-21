using AutoMapper;
using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModels;
using Radzen;
using TrackMyMacros.Dtos;
using TrackMyMacros.Dtos.WeightReading;
using GenericDataService = TrackMyMacros.App4.Services.GenericDataService;

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
        public Guid Id { get; set; }

        [Parameter]
        public bool EditMode { get; set; } = false;

        public async Task SaveAndClose()
        {
           
            if (EditMode)
            {
                await _foodComboDataService.Put<WeightReadingViewModel,UpdateWeightReadingDto>(WeightReading , GenericDataService.Endpoints.WeightReading);
            }
            else
            {
                await _foodComboDataService.Post<WeightReadingViewModel,CreateWeightReadingDto>(WeightReading, GenericDataService.Endpoints.WeightReading);
            }

            await OnDialogClose.InvokeAsync();
            DialogService.Close();
        }

        public void CancelClicked()
        {
            DialogService.Close();
        }
    }
}
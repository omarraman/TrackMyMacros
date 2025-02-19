using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Newtonsoft.Json;
using Radzen;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModels.ExerciseDaySet;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.App4.Components
{
    public partial class SetComponent
    {
        [Inject] public NavigationManager NavigationManager { get; set; }
        [Inject] public DialogService DialogService { get; set; }
        
        [Parameter]
        public EventCallback OnSetUpdated { get; set; }

        [Parameter] public GetSetViewModel Set { get; set; }

        public async Task OnSave(MouseEventArgs obj)
        {
            await OnSetUpdated.InvokeAsync();

        }
    }
}
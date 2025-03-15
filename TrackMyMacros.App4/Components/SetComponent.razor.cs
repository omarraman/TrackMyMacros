using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using TrackMyMacros.App4.ViewModels.Set;

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
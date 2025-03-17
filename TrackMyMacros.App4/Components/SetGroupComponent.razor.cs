using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.App4.ViewModels.SetGroup;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

namespace TrackMyMacros.App4.Components
{
    public partial class SetGroupComponent
    {
        [Parameter] public EventCallback<GetSetGroupViewModel> OnSetAdded { get; set; }
        [Parameter] public EventCallback OnSavePressed { get; set; }
        [Parameter] public GetSetGroupViewModel? SetGroup { get; set; }
        private async Task Save()
        {
            await OnSavePressed.InvokeAsync();
        }
    
        private void AddSet(MouseEventArgs args)
        {
            OnSetAdded.InvokeAsync(SetGroup);
        }

    }
}
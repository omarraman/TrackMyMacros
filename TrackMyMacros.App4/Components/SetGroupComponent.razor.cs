using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.Domain.Aggregates.Mesocycle;

namespace TrackMyMacros.App4.Components
{
    public partial class SetGroupComponent
    {
        [Parameter] public EventCallback<GetSetViewModel> OnSetAdded { get; set; }
        [Parameter] public GetSetViewModel? SetGroup { get; set; }

       // public async Task OnAddSet(Set set)
       //  {
       //      await OnSetAdded.InvokeAsync(set);
       //  }
    }
}
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TrackMyMacros.App4.ViewModels.SetGroup;

namespace TrackMyMacros.App4.Components
{
    public partial class ViewSetGroupComponent
    {
        [Parameter] public GetSetGroupViewModel? SetGroup { get; set; }
    }
}
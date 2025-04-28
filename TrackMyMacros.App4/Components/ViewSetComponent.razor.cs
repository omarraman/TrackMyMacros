using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TrackMyMacros.App4.ViewModels.Set;

namespace TrackMyMacros.App4.Components;

public partial class ViewSetComponent
{
    [Parameter] public GetSetViewModel Set { get; set; }
    
    public string Weight {
        get
        {
            var weight = Set.Weight.ToString();
            return weight;
        }
    }
        

    protected override void OnInitialized()
    {
        
    }
}
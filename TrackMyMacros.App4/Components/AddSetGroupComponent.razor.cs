using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TrackMyMacros.App4.ViewModels.Exercise;
using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.App4.ViewModels.SetGroup;

namespace TrackMyMacros.App4.Components;

public partial class AddSetGroupComponent
{
    
    [Parameter] public IReadOnlyList<GetExerciseViewModel> Exercises { get; set; }
    [Parameter] public CreateSetGroupViewModel SetGroup { get; set; }= new();

    [Parameter] public EventCallback<int> SetGroupMovedUp { get; set; }
    
    [Parameter] public EventCallback<int> SetGroupMovedDown { get; set; }
    [Parameter] public bool HasPrior { get; set; }
    [Parameter] public bool HasFollowing { get; set; }
    private void OnMoveUp(MouseEventArgs obj)
    {
        SetGroupMovedUp.InvokeAsync(SetGroup.Priority);
    }
    
    private void OnMoveDown(MouseEventArgs obj)
    {
        SetGroupMovedDown.InvokeAsync(SetGroup.Priority);
    }
}
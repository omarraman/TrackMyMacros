using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.ViewModels.Exercise;
using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.App4.ViewModels.SetGroup;

namespace TrackMyMacros.App4.Components;

public partial class AddSetGroupComponent
{
    
    [Parameter] public IReadOnlyList<GetExerciseViewModel> Exercises { get; set; }
    [Parameter] public CreateSetGroupViewModel SetGroup { get; set; }= new();
    
}
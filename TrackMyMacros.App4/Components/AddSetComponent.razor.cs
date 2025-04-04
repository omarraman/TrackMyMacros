using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.ViewModels.Exercise;
using TrackMyMacros.App4.ViewModels.Set;

namespace TrackMyMacros.App4.Components;

public partial class AddSetComponent
{
    
    [Parameter] public List<GetExerciseViewModel> Exercises { get; set; } = new();
    ///**/public CreateSetV Type { get; set; }
    
}
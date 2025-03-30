using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.ViewModels.Exercise;

namespace TrackMyMacros.App4.Components;

public partial class AddSetComponent
{
    
    [Parameter] public List<GetExerciseViewModel> Exercises { get; set; } = new();
    
}
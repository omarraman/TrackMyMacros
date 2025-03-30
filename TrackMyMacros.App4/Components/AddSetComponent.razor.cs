using Microsoft.AspNetCore.Components;

namespace TrackMyMacros.App4.Components;

public partial class AddSetComponent
{
    
    [Parameter] public List<GetExerciseViewModel> Exercises { get; set; } = new();
    
}
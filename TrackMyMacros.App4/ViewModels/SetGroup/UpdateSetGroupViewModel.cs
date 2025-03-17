using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.Domain.Aggregates.Exercise;

namespace TrackMyMacros.App4.ViewModels.SetGroup
{
    public class UpdateSetGroupViewModel
    {
        public List<UpdateSetViewModel> Sets { get; init; }
        public int Priority { get; set; }
        public Guid ExerciseId { get; init; }
        // public Exercise Exercise { get; set; }
    }
}
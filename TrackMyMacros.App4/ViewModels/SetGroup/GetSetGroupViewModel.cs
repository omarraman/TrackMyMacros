using TrackMyMacros.App4.ViewModels.Set;
using TrackMyMacros.Domain.Aggregates.Exercise;

namespace TrackMyMacros.App4.ViewModels.SetGroup
{
    public class GetSetGroupViewModel
    {
        public List<GetSetViewModel> Sets { get; init; }
        public int Priority { get; set; }
        public Guid ExerciseId { get; init; }
        public Exercise Exercise { get; set; }
        
        public string ExerciseName => Exercise.Name;
        
        public void AddFollowingSet()
        {
            var lastSet = Sets.Last();
            var newSet = lastSet.AddFollowingSet();
            Sets.Add(newSet);
        }
        
    }
}
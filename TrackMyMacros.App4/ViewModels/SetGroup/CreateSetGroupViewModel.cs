using System.Text.Json.Serialization;
using TrackMyMacros.App4.ViewModels.Set;

namespace TrackMyMacros.App4.ViewModels.SetGroup
{
    public class CreateSetGroupViewModel
    {
        public List<CreateSetViewModel> Sets { get; set; }
        public int Priority { get; set; }
        public Guid ExerciseId { get; set; }

        public bool HasPrior { get; set; }

        public bool HasFollowing { get; set; }

        [JsonIgnore]
        public Domain.Aggregates.Exercise.Exercise Exercise { get; set; }
    }
}
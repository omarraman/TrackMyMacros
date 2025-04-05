using System.Text.Json.Serialization;
using TrackMyMacros.App4.ViewModels.Set;

namespace TrackMyMacros.App4.ViewModels.SetGroup
{
    public class CreateSetGroupViewModel
    {
        public List<CreateSetViewModel> Sets { get; init; }
        public int Priority { get; set; }
        public Guid ExerciseId { get; init; }

        [JsonIgnore]
        public Domain.Aggregates.Exercise.Exercise Exercise { get; set; }
    }
}
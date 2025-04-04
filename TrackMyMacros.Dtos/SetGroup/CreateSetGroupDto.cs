using System.Text.Json.Serialization;
using TrackMyMacros.Dtos.Set;

namespace TrackMyMacros.Dtos.SetGroup{
    public class CreateSetGroupDto
    {
        public List<CreateSetDto> Sets { get; init; }
        public int Priority { get; set; }
        public Guid ExerciseId { get; init; }

    }
}
using TrackMyMacros.Domain.Aggregates.Exercise;
using TrackMyMacros.Dtos.Set;

namespace TrackMyMacros.Dtos.SetGroup
{
    public class UpdateSetGroupDto
    {
        public List<UpdateSetDto> Sets { get; init; }
        public int Priority { get; set; }
        public Guid ExerciseId { get; init; }
        // public Exercise Exercise { get; set; }
    }
}
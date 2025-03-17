using TrackMyMacros.Domain.Aggregates.Exercise;
using TrackMyMacros.Dtos.Set;

namespace TrackMyMacros.Dtos.SetGroup
{
    public class GetSetGroupDto
    {
        public List<GetSetDto> Sets { get; init; }
        public int Priority { get; set; }
        public Guid ExerciseId { get; init; }
        public Exercise Exercise { get; set; }
    }
}
using TrackMyMacros.Dtos.SetGroup;

namespace TrackMyMacros.Dtos.Workout
{
    public class UpdateWorkoutDto
    {
        public int DayOfWeek { get; init; }
        public List<UpdateSetGroupDto> SetGroups { get; init; }
    }
}
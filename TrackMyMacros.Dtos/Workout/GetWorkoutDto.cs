using TrackMyMacros.Dtos.SetGroup;

namespace TrackMyMacros.Dtos.Workout
{
    public class GetWorkoutDto
    {
        public int DayOfWeek { get; init; }
        public List<GetSetGroupDto> SetGroups { get; init; }
    }
}
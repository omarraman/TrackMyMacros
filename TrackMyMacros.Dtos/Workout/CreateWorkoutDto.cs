using TrackMyMacros.Dtos.SetGroup;

namespace Workout{
    public class CreateWorkoutDto
    {
        public int DayOfWeek { get; init; }
        public List<CreateSetGroupDto> SetGroups { get; init; }
    }
}
using TrackMyMacros.Dtos.Set;

namespace TrackMyMacros.Dtos.Workout
{
    public class UpdateWorkoutDto
    {
        public int DayOfWeek { get; init; }
        public List<UpdateSetDto> Sets { get; init; }
    }
}
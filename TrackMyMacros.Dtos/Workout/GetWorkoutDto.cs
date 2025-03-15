using TrackMyMacros.Dtos.Set;

namespace TrackMyMacros.Dtos.Workout
{
    public class GetWorkoutDto
    {
        public int DayOfWeek { get; init; }
        public List<GetSetDto> Sets { get; init; }
        public bool Complete { get; private set; }
    }
}
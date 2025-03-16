using TrackMyMacros.Dtos.Workout;

namespace TrackMyMacros.Dtos.Week
{
    public class GetWeekDto
    {
        public int WeekIndex { get; init; }
        public List<GetWorkoutDto> Workouts { get; init; }
    }
}
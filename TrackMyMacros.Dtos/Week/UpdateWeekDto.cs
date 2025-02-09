using TrackMyMacros.Dtos.Workout;

namespace TrackMyMacros.Dtos.Week
{
    public class UpdateWeekDto
    {
        public int WeekIndex { get; init; }
        public List<UpdateWorkoutDto> Workouts { get; init; }
    }
}
using Workout;

namespace Week{
    public class CreateWeekDto
    {
        public int WeekIndex { get; init; }
        public List<CreateWorkoutDto> Workouts { get; init; }
    }
}
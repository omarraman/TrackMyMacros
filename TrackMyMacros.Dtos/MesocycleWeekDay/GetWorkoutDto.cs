using TrackMyMacros.Dtos.ExerciseDaySet;

namespace TrackMyMacros.Dtos.MesocycleWeekDay
{
    public class GetWorkoutDto
    {
        public int DayOfWeek { get; init; }
        public List<GetSetDto> Sets { get; init; }
        public bool Complete { get; private set; }
    }
}
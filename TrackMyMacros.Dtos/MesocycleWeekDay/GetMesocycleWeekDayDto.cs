using TrackMyMacros.Dtos.ExerciseDaySet;

namespace TrackMyMacros.Dtos.MesocycleWeekDay
{
    public class GetMesocycleWeekDayDto
    {
        public int DayOfWeek { get; init; }
        public List<GetExerciseDaySetDto> ExerciseDaySets { get; init; }
        public bool Complete { get; private set; }
    }
}
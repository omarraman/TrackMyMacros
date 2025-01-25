using TrackMyMacros.Dtos.MesocycleWeekDay;

namespace TrackMyMacros.Dtos.MesocycleWeek
{
    public class GetWeekDto
    {
        public int WeekIndex { get; init; }
        public List<GetWorkoutDto> Workouts { get; init; }
    }
}
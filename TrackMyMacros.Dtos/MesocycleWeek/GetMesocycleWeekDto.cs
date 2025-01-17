using TrackMyMacros.Dtos.MesocycleWeekDay;

namespace TrackMyMacros.Dtos.MesocycleWeek
{
    public class GetMesocycleWeekDto
    {
        public int WeekIndex { get; init; }
        public List<GetMesocycleWeekDayDto> MesocycleWeekDays { get; init; }
    }
}
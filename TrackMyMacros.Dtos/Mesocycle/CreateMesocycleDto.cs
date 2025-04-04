using TrackMyMacros.SharedKernel;
using Week;

namespace TrackMyMacros.Dtos.Mesocycle{
    public class CreateMesocycleDto
    {
        public string Name { get; set; }
        public List<CreateWeekDto> Weeks { get; set; }
        public int TotalWeeks { get; set; }
        public bool Complete { get; set; }
        public int CurrentWeekIndex { get; set; } = 1;
        public int CurrentDayOfWeek { get; set; } = 1;
    }
}
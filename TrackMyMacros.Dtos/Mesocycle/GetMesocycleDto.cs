using TrackMyMacros.Dtos.Week;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Dtos.Mesocycle
{
    public class GetMesocycleDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<GetWeekDto> Weeks { get; set; }
        public int CurrentWeekIndex { get; set; } 
        public int CurrentDayOfWeek { get; set; } 
        public int  TotalWeeks { get; set; }
        public bool Complete { get; set; }
    }
}
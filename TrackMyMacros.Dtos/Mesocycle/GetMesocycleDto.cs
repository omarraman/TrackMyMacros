using TrackMyMacros.Dtos.MesocycleWeek;

namespace TrackMyMacros.Dtos.Mesocycle
{
    public class GetMesocycleDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<GetWeekDto> Weeks { get; set; }
        public int CurrentWeekIndex { get; set; } 
        public int CurrentDayOfWeek { get; set; } 
    }
}
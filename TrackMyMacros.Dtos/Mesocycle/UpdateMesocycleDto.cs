using TrackMyMacros.Dtos.Week;

namespace TrackMyMacros.Dtos.Mesocycle
{
    public class UpdateMesocycleDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<UpdateWeekDto> Weeks { get; set; }
        public int CurrentWeekIndex { get; set; } = 1;
        public int CurrentDayOfWeek { get; set; } =1;

        public bool CurrentWorkoutComplete { get; set; } = false;
        public int  TotalWeeks { get; set; }
    }
}
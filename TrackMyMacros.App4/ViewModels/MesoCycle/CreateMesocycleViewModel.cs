using TrackMyMacros.App4.ViewModels.Week;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.ViewModels.Mesocycle
{
    public class CreateMesocycleViewModel
    {
        public string Name { get; set; }
        public List<CreateWeekViewModel> Weeks { get; set; }
        public int TotalWeeks { get; set; }
        public bool Complete { get; set; }
        public int CurrentWeekIndex { get; set; } = 1;
        public MyDayOfWeek CurrentDayOfWeek { get; set; } = MyDayOfWeek.Monday();
    }
}
using TrackMyMacros.App4.ViewModels.Week;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.App4.ViewModels.Mesocycle
{
    public class UpdateMesocycleViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<UpdateWeekViewModel> Weeks { get; set; }
        public int CurrentWeekIndex { get; set; } = 1;
        public MyDayOfWeek CurrentDayOfWeek { get; set; } = MyDayOfWeek.Monday();
        public bool CurrentWorkoutComplete { get; set; } = false;
    }
}
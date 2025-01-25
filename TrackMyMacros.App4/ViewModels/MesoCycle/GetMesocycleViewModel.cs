using TrackMyMacros.App4.ViewModels.MesocycleWeek;

namespace TrackMyMacros.App4.ViewModels.Mesocycle
{
    public class GetMesocycleViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<GetWeekViewModel> Weeks { get; set; }
    }
}
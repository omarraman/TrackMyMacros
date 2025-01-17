namespace TrackMyMacros.App4.ViewModels.Mesocycle
{
    public class GetMesocycleViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<GetMesocycleWeekViewModel> MesocycleWeeks { get; set; }
    }
}
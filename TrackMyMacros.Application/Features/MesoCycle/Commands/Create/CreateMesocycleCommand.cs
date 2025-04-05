using TrackMyMacros.Application.Features.Week.Commands.Create;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Features.MesoCycle.Commands.Create{
    public class CreateMesocycleCommand : RequestBase<Result<Guid>>
    {
        public string Name { get; set; }
        public List<CreateWeekCommand> Weeks { get; set; }
        public int TotalWeeks { get; set; }
        public bool Complete { get; set; }
        public int CurrentWeekIndex { get; set; } = 1;
        public MyDayOfWeek CurrentDayOfWeek { get; set; } = MyDayOfWeek.Monday();
    }
}
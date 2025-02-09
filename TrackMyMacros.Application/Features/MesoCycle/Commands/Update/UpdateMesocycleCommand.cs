using TrackMyMacros.Application.Features.Week.Commands.Update;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Features.Mesocycle.Commands.Update
{
    public class UpdateMesocycleCommand : RequestBase<Result>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<UpdateWeekCommand> Weeks { get; set; }
        public int CurrentWeekIndex { get; init; } = 1;
        public MyDayOfWeek CurrentDayOfWeek { get; set; } = MyDayOfWeek.Monday();
        public bool CurrentWorkoutComplete { get; set; } = false;
    }
}
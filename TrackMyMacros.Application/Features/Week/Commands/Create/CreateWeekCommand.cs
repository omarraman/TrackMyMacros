using TrackMyMacros.Application.Features.Workout.Commands.Create;

namespace TrackMyMacros.Application.Features.Week.Commands.Create{
    public class CreateWeekCommand : RequestBase<Result<Guid>>
    {
        public int WeekIndex { get; init; }
        public List<CreateWorkoutCommand> Workouts { get; init; }
    }
}
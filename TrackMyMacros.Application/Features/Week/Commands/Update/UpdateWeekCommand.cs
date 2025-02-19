using TrackMyMacros.Application.Features.Workout.Commands.Update;

namespace TrackMyMacros.Application.Features.Week.Commands.Update
{
    public class UpdateWeekCommand : RequestBase<Result>
    {
        public int WeekIndex { get; init; }
        public List<UpdateWorkoutCommand> Workouts { get; init; }
    }
}
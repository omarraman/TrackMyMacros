using TrackMyMacros.Application.Features.Set.Commands.Update;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Features.Workout.Commands.Update
{
    public class UpdateWorkoutCommand : RequestBase<Result>
    {
        public MyDayOfWeek DayOfWeek { get; init; }
        public List<UpdateSetCommand> Sets { get; init; }
    }
}
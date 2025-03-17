using TrackMyMacros.Application.Features.SetGroup.Commands.Update;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Features.Workout.Commands.Update
{
    public class UpdateWorkoutCommand : RequestBase<Result>
    {
        public MyDayOfWeek DayOfWeek { get; init; }
        public List<UpdateSetGroupCommand> SetGroups { get; init; }
    }
}
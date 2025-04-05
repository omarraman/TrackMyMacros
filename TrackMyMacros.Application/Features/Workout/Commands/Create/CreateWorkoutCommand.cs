using TrackMyMacros.Application.Features.SetGroup.Commands.Create;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Features.Workout.Commands.Create{
    public class CreateWorkoutCommand : RequestBase<Result<Guid>>
    {
        public MyDayOfWeek DayOfWeek { get; init; }
        public List<CreateSetGroupCommand> SetGroups { get; init; }
    }
}
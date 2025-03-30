using TrackMyMacros.Application.Features.Set.Commands.Update;
using TrackMyMacros.Domain.Aggregates.Exercise;

namespace TrackMyMacros.Application.Features.SetGroup.Commands.Update
{
    public class UpdateSetGroupCommand : RequestBase<Result>
    {
        public List<UpdateSetCommand> Sets { get; init; }
        public int Priority { get; set; }
        public Guid ExerciseId { get; init; }
        public Domain.Aggregates.Exercise.Exercise Exercise { get; set; }
    }
}
using System.Text.Json.Serialization;
using TrackMyMacros.Application.Features.Set.Commands.Create;

namespace TrackMyMacros.Application.Features.SetGroup.Commands.Create{
    public class CreateSetGroupCommand : RequestBase<Result<Guid>>
    {
        public List<CreateSetCommand> Sets { get; init; }
        public int Priority { get; set; }
        public Guid ExerciseId { get; init; }

        [JsonIgnore]
        public Domain.Aggregates.Exercise.Exercise Exercise { get; set; }
    }
}
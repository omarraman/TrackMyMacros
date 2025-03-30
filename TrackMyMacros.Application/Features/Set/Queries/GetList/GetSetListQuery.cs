using TrackMyMacros.Domain.Aggregates.Exercise;
using TrackMyMacros.Dtos.Set;

namespace TrackMyMacros.Application.Features.Set.Queries.GetList
{
    public class GetSetListQuery : RequestBase<IReadOnlyList<GetSetDto>>
    {
        // public Set(int reps, int targetReps, double targetWeight, Guid exerciseId)
        // {
        //     Reps = reps;
        //     TargetReps = targetReps;
        //     TargetWeight = targetWeight;
        //     ExerciseId = exerciseId;
        // }
        public int Reps { get; init; }
        public double Weight { get; init; }
        public int TargetReps { get; init; }
        public double TargetWeight { get; init; }
        public Guid ExerciseId { get; init; }
        public Domain.Aggregates.Exercise.Exercise Exercise { get; set; }
    }
}
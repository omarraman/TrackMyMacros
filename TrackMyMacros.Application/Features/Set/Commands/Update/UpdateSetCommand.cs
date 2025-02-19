using TrackMyMacros.Domain.Aggregates.Exercise;

namespace TrackMyMacros.Application.Features.Set.Commands.Update
{
    public class UpdateSetCommand : RequestBase<Result>
    {
        // public Set(int reps, int targetReps, double targetWeight, Guid exerciseId)
        // {
        //     Reps = reps;
        //     TargetReps = targetReps;
        //     TargetWeight = targetWeight;
        //     ExerciseId = exerciseId;
        // }
        public int Reps { get; init; }
        public int Weight { get; init; }
        public int TargetReps { get; init; }
        public double TargetWeight { get; init; }
        public Guid ExerciseId { get; init; }
        public bool BodyWeightExercise { get; init; }
        public bool WeightIncrease { get; init; }
        public bool RepIncrease { get; init; }
    }
}
using TrackMyMacros.Domain.Aggregates.Exercise;

namespace TrackMyMacros.App4.ViewModels.Set
{
    public class UpdateSetViewModel
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
        public Exercise Exercise { get; set; }
        public bool BodyWeightExercise { get; init; }
        public bool WeightIncrease { get; init; }
        public bool RepIncrease { get; init; }
    }
}
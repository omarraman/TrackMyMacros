namespace TrackMyMacros.Dtos.Set
{
    public class UpdateSetDto
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
        public bool BodyWeightExercise { get; init; }
        public bool WeightIncrease { get; init; }
        public bool RepIncrease { get; init; }
        // public Exercise.Exercise Exercise { get; set; }
    }
}
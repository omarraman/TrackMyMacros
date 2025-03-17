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
        public int TargetReps { get; set; }
        public double TargetWeight { get; set; }
        public int Number { get; set; }
    }
}
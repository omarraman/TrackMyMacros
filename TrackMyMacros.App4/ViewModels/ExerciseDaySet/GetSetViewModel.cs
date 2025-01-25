namespace TrackMyMacros.App4.ViewModels.ExerciseDaySet
{
    public class GetSetViewModel
    {
        public int Reps { get; init; }
        public int TargetReps { get; init; }
        public double TargetWeight { get; init; }
        public Guid ExerciseId { get; init; }
        public string ExerciseName { get; set; }
    }
}
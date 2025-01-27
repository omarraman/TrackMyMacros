namespace TrackMyMacros.App4.ViewModels.ExerciseDaySet
{
    public class GetSetViewModel
    {
        public int Reps { get; set; }
        public double Weight { get; set; }
        public int TargetReps { get; set; }
        public double TargetWeight { get; set; }
        public Guid ExerciseId { get; set; }
        public string ExerciseName { get; set; }
    }
}
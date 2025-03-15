using TrackMyMacros.Domain.Aggregates.Exercise;

namespace TrackMyMacros.App4.ViewModels.Set
{
    public class GetSetViewModel
    {
        public int Reps { get; set; }
        public double Weight { get; set; }
        public int TargetReps { get; set; }
        public double TargetWeight { get; set; }
        public Guid ExerciseId { get; set; }
        public string ExerciseName { get; set; }
        public bool BodyWeightExercise { get; set; }
        public bool WeightIncrease { get; set; }
        public bool RepIncrease { get; set; }
        public int Priority { get; set; }
        public int Number { get; set; }
    }
}
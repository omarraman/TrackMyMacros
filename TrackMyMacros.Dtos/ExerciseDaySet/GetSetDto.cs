namespace TrackMyMacros.Dtos.ExerciseDaySet
{
    public class GetSetDto
    {
        public int Reps { get; init; }
        public int TargetReps { get; init; }
        public double TargetWeight { get; init; }
        public double Weight { get; init; }
        public Guid ExerciseId { get; init; }
        public string ExerciseName { get; init; }
        
    }
}
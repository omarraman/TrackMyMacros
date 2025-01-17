namespace TrackMyMacros.Dtos.ExerciseDaySet
{
    public class GetExerciseDaySetDto
    {
        public int Reps { get; init; }
        public int TargetReps { get; init; }
        public double TargetWeight { get; init; }
        public Guid ExerciseId { get; init; }
    }
}
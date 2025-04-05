namespace TrackMyMacros.Application.Features.Set.Commands.Create
{
    public class CreateSetCommand : RequestBase<Result<Guid>>
    {
        // public Set(int reps, int targetReps, double targetWeight, Guid exerciseId)
        // {
        //     Reps = reps;
        //     TargetReps = targetReps;
        //     TargetWeight = targetWeight;
        //     ExerciseId = exerciseId;
        // }
        public int Reps { get; init; }
        public double Weight { get; set; }
        public int TargetReps { get; set; }
        public double TargetWeight { get; set; }
        public int Number { get; set; }
    }
}
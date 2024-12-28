using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;
public class ExerciseDaySet : ValueObject<ExerciseDaySet>
{
    public ExerciseDaySet(int reps, int targetReps, double targetWeight, Guid exerciseId)
    {
        Reps = reps;
        TargetReps = targetReps;
        TargetWeight = targetWeight;
        ExerciseId = exerciseId;
    }

    public int Reps { get; init; }
    public int TargetReps { get; init; }
    public double TargetWeight { get; init; }
    public Guid ExerciseId { get; init; }
    protected override bool EqualsCore(ExerciseDaySet other)
    {
        return TargetWeight == other.TargetWeight && Reps == other.Reps && TargetReps == other.TargetReps 
            && ExerciseId == other.ExerciseId ;
        }

    protected override int GetHashCodeCore()
    {
        throw new NotImplementedException();
    }
}

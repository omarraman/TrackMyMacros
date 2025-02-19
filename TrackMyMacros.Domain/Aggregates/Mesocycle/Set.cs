using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Mesocycle;
public class Set : ValueObject<Set>
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

    public Exercise.Exercise Exercise { get; set; }
    protected override bool EqualsCore(Set other)
    {
        return TargetWeight == other.TargetWeight && Reps == other.Reps && TargetReps == other.TargetReps 
            && Exercise.Id == other.Exercise.Id ;
        }

    protected override int GetHashCodeCore()
    {
        throw new NotImplementedException();
    }
}

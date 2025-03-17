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
    public int TargetReps { get; set; }
    public double TargetWeight { get; set; }
    
    public int Number { get; set; }


    protected override bool EqualsCore(Set other)
    {
        return Math.Abs(TargetWeight - other.TargetWeight) < 0.1 && Reps == other.Reps && TargetReps == other.TargetReps 
            ;
        }

    protected override int GetHashCodeCore()
    {
        throw new NotImplementedException();
    }
}

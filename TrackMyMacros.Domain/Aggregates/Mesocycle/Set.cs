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
    public double Weight { get; set; }
    public int TargetReps { get; set; }
    public double TargetWeight { get; set; }
    
    public int Number { get; set; }

    public Set Update(double targetWeight,int targetReps, double newWeight, int newReps)
    {
        return new Set
        {
            Weight = newWeight,
            Reps = newReps,
            TargetReps = targetReps,
            TargetWeight = targetWeight
        };
    }

    public string IsValid()
    {
        if (Reps < 1)
            return "Reps must be greater than 0";
        if (TargetReps < 1)
            return "Target Reps must be greater than 0";
        if (TargetWeight < 0)
            return "Target Weight must be greater than or equal to 0";
        if (Weight < 0)
            return "Weight must be greater than or equal to 0";
        return string.Empty;
    }

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

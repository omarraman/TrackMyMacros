using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;
public class ExerciseSet : ValueObject<ExerciseSet>
{
    public int Reps { get; set; }
    public int TargetReps { get; set; }
    public double TargetWeight { get; set; }
    public Guid ExerciseId { get; set; }
    protected override bool EqualsCore(ExerciseSet other)
    {
        return TargetWeight == other.TargetWeight && Reps == other.Reps && TargetReps == other.TargetReps 
            && ExerciseId == other.ExerciseId ;
        }

    protected override int GetHashCodeCore()
    {
        throw new NotImplementedException();
    }
}

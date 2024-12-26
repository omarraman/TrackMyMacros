using System.Security.AccessControl;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

public class ExerciseDay : ValueObject<ExerciseDay>
{
    public DayOfWeek DayOfWeek { get; init; }
    public List<ExerciseSet> ExerciseSets { get; init; }

    public bool Complete { get; private set; }

    private ExerciseDay()
    {
        
    }
    public ExerciseDay(DayOfWeek dayOfWeek, List<ExerciseSet> exerciseSets)
    {
        ExerciseSets = exerciseSets;
        DayOfWeek = dayOfWeek;
    }

    public void MarkComplete()
    {
        Complete = true;
    }
    
    protected override bool EqualsCore(ExerciseDay other)
    {
        if (DayOfWeek != other.DayOfWeek)
            return false;

        if (ExerciseSets.Count != other.ExerciseSets.Count)
            return false;

        for (int i = 0; i < ExerciseSets.Count; i++)
        {
            if (!ExerciseSets[i].Equals(other.ExerciseSets[i]))
                return false;
        }

        return true;
    }

    protected override int GetHashCodeCore()
    {
        int hashCode = DayOfWeek.GetHashCode();

        foreach (var exerciseSet in ExerciseSets)
        {
            hashCode = HashCode.Combine(hashCode, exerciseSet);
        }

        return hashCode;
    }
}
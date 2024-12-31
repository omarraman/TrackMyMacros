using System.Security.AccessControl;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

public class MesocycleWeekDay : ValueObject<MesocycleWeekDay>
{
    public DayOfWeek DayOfWeek { get; init; }
    public List<ExerciseDaySet> ExerciseDaySets { get; init; }

    public bool Complete { get; private set; }

    private MesocycleWeekDay()
    {
        
    }
    public MesocycleWeekDay(DayOfWeek dayOfWeek, List<ExerciseDaySet> exerciseDaySets)
    {
        ExerciseDaySets = exerciseDaySets;
        DayOfWeek = dayOfWeek;
    }

    public void MarkComplete()
    {
        Complete = true;
    }
    
    protected override bool EqualsCore(MesocycleWeekDay other)
    {
        if (DayOfWeek != other.DayOfWeek)
            return false;

        if (ExerciseDaySets.Count != other.ExerciseDaySets.Count)
            return false;

        for (int i = 0; i < ExerciseDaySets.Count; i++)
        {
            if (!ExerciseDaySets[i].Equals(other.ExerciseDaySets[i]))
                return false;
        }

        return true;
    }

    protected override int GetHashCodeCore()
    {
        int hashCode = DayOfWeek.GetHashCode();

        foreach (var exerciseSet in ExerciseDaySets)
        {
            hashCode = HashCode.Combine(hashCode, exerciseSet);
        }

        return hashCode;
    }
}
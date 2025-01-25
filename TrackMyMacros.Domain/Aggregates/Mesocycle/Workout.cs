using TrackMyMacros.Domain.ValueObjects;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Domain.Aggregates.Mesocycle;

public class Workout : Common.ValueObject<Workout>
{
    public MyDayOfWeek DayOfWeek { get; init; }
    public List<Set> Sets { get; init; }

    private Workout()
    {
        
    }
    public Workout(MyDayOfWeek dayOfWeek, List<Set> sets)
    {
        Sets = sets;
        DayOfWeek = dayOfWeek;
    }



    protected override bool EqualsCore(Workout other)
    {
        if (DayOfWeek != other.DayOfWeek)
            return false;

        if (Sets.Count != other.Sets.Count)
            return false;

        for (int i = 0; i < Sets.Count; i++)
        {
            if (!Sets[i].Equals(other.Sets[i]))
                return false;
        }

        return true;
    }

    protected override int GetHashCodeCore()
    {
        int hashCode = DayOfWeek.GetHashCode();

        foreach (var exerciseSet in Sets)
        {
            hashCode = HashCode.Combine(hashCode, exerciseSet);
        }

        return hashCode;
    }
}
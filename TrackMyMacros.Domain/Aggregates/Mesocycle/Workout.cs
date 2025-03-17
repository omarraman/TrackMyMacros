using System.Text.Json;
using TrackMyMacros.Domain.ValueObjects;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Domain.Aggregates.Mesocycle;

public class Workout : Common.ValueObject<Workout>
{
    public MyDayOfWeek DayOfWeek { get; init; }
    public List<SetGroup> SetGroups { get; init; }

    private Workout()
    {
    }

    public Workout(MyDayOfWeek dayOfWeek, List<SetGroup> set)
    {
        SetGroups = set;
        DayOfWeek = dayOfWeek;
    }


    protected override bool EqualsCore(Workout other)
    {
        if (DayOfWeek != other.DayOfWeek)
            return false;

        var setGroupJson = JsonSerializer.Serialize(SetGroups);
        var otherSetGroupJson = JsonSerializer.Serialize(other.SetGroups);
        if (setGroupJson != otherSetGroupJson)
            return false;

        return true;
    }

    protected override int GetHashCodeCore()
    {
        int hashCode = DayOfWeek.GetHashCode();

        foreach (var exerciseSet in SetGroups)
        {
            hashCode = HashCode.Combine(hashCode, exerciseSet);
        }

        return hashCode;
    }
}
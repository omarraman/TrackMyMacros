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
    
    public string IsValid()
    {
        //all the workouts within a week must be on separate days
        //workout days are Monday, Tuesday,Wednesday etc
        if (SetGroups == null || SetGroups.Count == 0)
            return "Workout must have at least one set";

        foreach (var setGroup in SetGroups)
        {
            var validationErrors = setGroup.IsValid();
            if (validationErrors != "")
                return validationErrors;
        }


        return "";
    }

    public Workout(MyDayOfWeek dayOfWeek, List<SetGroup> setGroups)
    {
        SetGroups = setGroups;
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
using System.Text.Json;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Mesocycle;

public class SetGroup : ValueObject<SetGroup>
{
    public List<Set> Sets { get; init; }
    public int Priority { get; set; }
    public Guid ExerciseId { get; init; }

    public Exercise.Exercise Exercise { get; set; }

    protected override bool EqualsCore(SetGroup other)
    {
        var otherJson = JsonSerializer.Serialize(other);
        var thisJson = JsonSerializer.Serialize(this);
        return otherJson == thisJson;
    }

    protected override int GetHashCodeCore()
    {
        int hashCode = Priority.GetHashCode();
        foreach (var set in Sets)
        {
            hashCode = HashCode.Combine(hashCode, set);
        }

        return hashCode;
    }
}
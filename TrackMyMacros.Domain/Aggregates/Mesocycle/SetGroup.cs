using System.Text.Json;
using System.Text.Json.Serialization;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Mesocycle;

public class SetGroup : ValueObject<SetGroup>
{
    public List<Set> Sets { get; init; }
    public int Priority { get; set; }
    public Guid ExerciseId { get; init; }

    [JsonIgnore] public Exercise.Exercise Exercise { get; set; }

    protected override bool EqualsCore(SetGroup other)
    {
        var otherJson = JsonSerializer.Serialize(other);
        var thisJson = JsonSerializer.Serialize(this);
        return otherJson == thisJson;
    }

    public string IsValid()
    {
        //count of priority must be the same as the count of sets
        /*
        if (Sets.Count != Priority)
        {
            return "The number of sets must be equal to the priority";
        }
        */

        foreach (var set in Sets)
        {
            var validationMessage = set.IsValid();
            if (!string.IsNullOrEmpty(validationMessage))
            {
                return validationMessage;
            }
        }

        return "";
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
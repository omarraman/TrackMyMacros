using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

public class NanoCycle : ValueObject<NanoCycle>
{
    private readonly DayOfWeek _dayOfWeek;
    private readonly List<ExerciseSet> _exerciseSets;
    private DayOfWeek DayOfWeek { get; set; }
    private List<ExerciseSet> ExerciseSets { get; set; }

    public NanoCycle(DayOfWeek dayOfWeek, List<ExerciseSet> exerciseSets)
    {
        _dayOfWeek = dayOfWeek;
        _exerciseSets = exerciseSets;
    }

    protected override bool EqualsCore(NanoCycle other)
    {
        if (DayOfWeek != other.DayOfWeek)
            return false;

        if (_exerciseSets.Count != other._exerciseSets.Count)
            return false;

        for (int i = 0; i < _exerciseSets.Count; i++)
        {
            if (!_exerciseSets[i].Equals(other._exerciseSets[i]))
                return false;
        }

        return true;
    }

    protected override int GetHashCodeCore()
    {
        int hashCode = _dayOfWeek.GetHashCode();

        foreach (var exerciseSet in _exerciseSets)
        {
            hashCode = HashCode.Combine(hashCode, exerciseSet);
        }

        return hashCode;
    }
}
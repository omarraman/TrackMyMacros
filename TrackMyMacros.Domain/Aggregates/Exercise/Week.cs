using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

public class Week : ValueObject<Week>
{
    public int WeekIndex { get; init; }
    public List<WeekExerciseDay> WeekExerciseDays { get; init; }

    private Week()
    {
        
    }

    public Week(int weekIndex, List<WeekExerciseDay> weekExerciseDays)
    {
        WeekIndex = weekIndex;
        WeekExerciseDays = weekExerciseDays;
    }

    // public void CreateNewDefaultWeek(int weekIndex)
    // {
    //     WeekIndex = weekIndex;
    //     NanoCycles = new List<NanoCycle>();
    //     
    //     var nanoCycle = new NanoCycle(DayOfWeek.Monday(), new List<ExerciseSet>());
    //     var exerciseSet = new ExerciseSet(10, 10, 100, Guid.NewGuid());
    //     NanoCycles.Add(nanoCycle);
    //
    // }

    protected override bool EqualsCore(Week other)
    {
        throw new NotImplementedException();
    }

    protected override int GetHashCodeCore()
    {
        int hashCode = WeekIndex;
        foreach (var nanoCycle in WeekExerciseDays)
        {
            hashCode = HashCode.Combine(hashCode, nanoCycle);
        }

        return hashCode;
    }
}
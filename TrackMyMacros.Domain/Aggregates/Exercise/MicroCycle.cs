using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

public class MicroCycle : ValueObject<MicroCycle>
{
    public int WeekIndex { get; init; }
    public List<ExerciseDay> ExerciseDays { get; init; }

    private MicroCycle()
    {
        
    }

    public MicroCycle(int weekIndex, List<ExerciseDay> exerciseDays)
    {
        WeekIndex = weekIndex;
        ExerciseDays = exerciseDays;
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

    protected override bool EqualsCore(MicroCycle other)
    {
        throw new NotImplementedException();
    }

    protected override int GetHashCodeCore()
    {
        int hashCode = WeekIndex;
        foreach (var nanoCycle in ExerciseDays)
        {
            hashCode = HashCode.Combine(hashCode, nanoCycle);
        }

        return hashCode;
    }
}
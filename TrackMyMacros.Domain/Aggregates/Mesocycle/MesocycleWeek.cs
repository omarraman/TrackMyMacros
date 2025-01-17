using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Mesocycle;

public class MesocycleWeek : ValueObject<MesocycleWeek>
{
    public int WeekIndex { get; init; }
    public List<MesocycleWeekDay> MesocycleWeekDays { get; init; }

    private MesocycleWeek()
    {
        
    }

    public MesocycleWeek(int weekIndex, List<MesocycleWeekDay> mesocycleWeekDays)
    {
        WeekIndex = weekIndex;
        MesocycleWeekDays = mesocycleWeekDays;
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

    protected override bool EqualsCore(MesocycleWeek other)
    {
        throw new NotImplementedException();
    }

    protected override int GetHashCodeCore()
    {
        int hashCode = WeekIndex;
        foreach (var nanoCycle in MesocycleWeekDays)
        {
            hashCode = HashCode.Combine(hashCode, nanoCycle);
        }

        return hashCode;
    }
}
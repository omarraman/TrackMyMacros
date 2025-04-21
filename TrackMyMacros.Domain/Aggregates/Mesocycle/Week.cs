using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Mesocycle;

public class Week : ValueObject<Week>
{
    public int WeekIndex { get; init; }
    public List<Workout> Workouts { get; init; }

    private Week()
    {
        
    }

    public Week(int weekIndex, List<Workout> workouts)
    {
        WeekIndex = weekIndex;
        Workouts = workouts;
    }

    public string IsValid()
    {
        var distinctDays = Workouts.Select(m=> m.DayOfWeek).Distinct().ToList();
        if (distinctDays.Count != Workouts.Count)
            return "Workouts in a week must be on separate days";
        if (Workouts.Count==0)
            return "A week must have at least one workout";
        foreach (var workout in Workouts)
        {
            var workoutValidation = workout.IsValid();
            if (!string.IsNullOrEmpty(workoutValidation))
                return workoutValidation;
        }
        
        return String.Empty;
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
        foreach (var nanoCycle in Workouts)
        {
            hashCode = HashCode.Combine(hashCode, nanoCycle);
        }

        return hashCode;
    }
}
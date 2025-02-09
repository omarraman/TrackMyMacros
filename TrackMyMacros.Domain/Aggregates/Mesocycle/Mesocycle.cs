using TrackMyMacros.Attributes;
using TrackMyMacros.Domain.Common;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Domain.Aggregates.Mesocycle;

[CodeGen]
public class Mesocycle:Entity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Week> Weeks { get; set; }

    public int CurrentWeekIndex { get; set; } = 1;
    public MyDayOfWeek CurrentDayOfWeek { get; set; } = MyDayOfWeek.Monday();

    public void AdvanceMesocycleToNextWorkout()
    {
        if (CurrentDayOfWeek == MyDayOfWeek.Friday())
        {
            CurrentDayOfWeek = MyDayOfWeek.Monday();
            CurrentWeekIndex++;
        }
        else if (CurrentDayOfWeek == MyDayOfWeek.Monday())
        {
            CurrentDayOfWeek = MyDayOfWeek.Wednesday();
        }
        else
        {
            CurrentDayOfWeek = MyDayOfWeek.Friday();
        }
        
        if (GetCurrentWeek().HasNoValue)
        {
            DuplicatePreviousWeek(this, CurrentWeekIndex);
           //create a new week
        }
        
        if (GetCurrentWorkout().HasNoValue)
        {
            //create a new workout
        }
    }
    
    private Maybe<Week> GetCurrentWeek()
    {
        return Weeks.SingleOrDefault(m=>m.WeekIndex==CurrentWeekIndex);
    }

    public Maybe<Workout> GetCurrentWorkout()
    {
        if (GetCurrentWeek().HasNoValue)
        {
            return Maybe<Workout>.None;
        }
        
        return GetCurrentWeek().Value.Workouts.SingleOrDefault(x => x.DayOfWeek == CurrentDayOfWeek);
    }
    
    public static Week DuplicatePreviousWeek(Mesocycle mesocycle, int weekIndex)
    {
        var weekToDuplicate = mesocycle.Weeks.SingleOrDefault(w => w.WeekIndex == weekIndex-1);
        if (weekToDuplicate == null)
        {
            throw new InvalidOperationException("Week with WeekIndex 1 not found in the Mesocycle.");
        }
        
        var newWorkoutsForWeek =weekToDuplicate.Workouts.Select(workout => new Workout
        (
            workout.DayOfWeek,
            workout.Sets.Select(set => new Set
            {
                Weight = set.Weight + set.Exercise.BodyPart.Size,
                Reps = set.Reps,
                TargetReps = set.TargetReps,
                TargetWeight = set.TargetWeight,
                ExerciseId = set.ExerciseId
            }).ToList()
        )).ToList();

        
        
        var newWeek = new Week(weekIndex,newWorkoutsForWeek);

        return newWeek;
    }
    
    private double GetWeightIncrease(double weight, double size)
    {
        return weight + size;
    }
    
    
    //write a method to generate a new workout
    
    
    // public void CreateNewDefault()
    // {
    //     MicroCycles = new List<MicroCycle>();
    //     var microCycle = new MicroCycle(1, new List<NanoCycle>());
    //     
    //     var firstMondayNanoCycle = new NanoCycle(DayOfWeek.Monday(), new List<ExerciseSet>()
    //     {
    //         new ExerciseSet(0, 14, 20, Exercise.InclineDumbbellPress().Id),
    //         new ExerciseSet(0, 12, 49, Exercise.PullDown().Id),
    //         new ExerciseSet(0, 8, 50, Exercise.Squat().Id),
    //         new ExerciseSet(0, 10, 40, Exercise.CalvesTwoSecondPause().Id),
    //         new ExerciseSet(0, 8, 9, Exercise.LyingDumbellBicepCurl().Id),
    //         new ExerciseSet(0, 10, 17, Exercise.LyingOverheadTricepsExtension().Id),
    //         new ExerciseSet(0, 3, 100, Exercise.ReverseNordics().Id),
    //         new ExerciseSet(0, 7, 7, Exercise.SingleArmCableLateralRaise().Id),
    //         new ExerciseSet(0, 5, 10, Exercise.CableCrunch().Id)
    //     });
    //     
    //     var firstWednesdayNanoCycle = new NanoCycle(DayOfWeek.Wednesday(), new List<ExerciseSet>()
    //     {
    //         new ExerciseSet(0, 12, 20, Exercise.InclineDumbbellPress().Id),
    //         new ExerciseSet(0, 10, 46.5, Exercise.DualCableRow().Id),
    //         new ExerciseSet(0, 9, 45, Exercise.RDL().Id),
    //         new ExerciseSet(0, 8, 41.5, Exercise.CalvesFourSecondEccentric().Id),
    //         new ExerciseSet(0, 8, 9, Exercise.LyingDumbellBicepCurl().Id),
    //         new ExerciseSet(0, 10, 17, Exercise.LyingOverheadTricepsExtension().Id),
    //         new ExerciseSet(0, 3, 100, Exercise.ReverseNordics().Id),
    //         new ExerciseSet(0, 7, 7, Exercise.SingleArmCableLateralRaise().Id),
    //         new ExerciseSet(0, 5, 10, Exercise.CableCrunch().Id)
    //     });
    //     
    //     var firstFridayNanocycle = new NanoCycle(DayOfWeek.Friday(), new List<ExerciseSet>()
    //     {
    //         new ExerciseSet(0, 10, 100, Exercise.Flyes().Id),
    //         new ExerciseSet(0, 12, 49, Exercise.PullDown().Id),
    //         new ExerciseSet(0, 8, 50, Exercise.Squat().Id),
    //         new ExerciseSet(0, 10, 40, Exercise.CalvesTwoSecondPause().Id),
    //         new ExerciseSet(0, 8, 9, Exercise.LyingDumbellBicepCurl().Id),
    //         new ExerciseSet(0, 10, 17, Exercise.LyingOverheadTricepsExtension().Id),
    //         new ExerciseSet(0, 3, 100, Exercise.ReverseNordics().Id),
    //         new ExerciseSet(0, 7, 7, Exercise.SingleArmCableLateralRaise().Id),
    //         new ExerciseSet(0, 5, 10, Exercise.CableCrunch().Id)
    //     });
    // }
}
using System.Text.Json;
using TrackMyMacros.Attributes;
using TrackMyMacros.Domain.Common;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Domain.Aggregates.Mesocycle;

[CodeGen]
public class Mesocycle : Entity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Week> Weeks { get; set; }

    public int TotalWeeks { get; set; }

    public bool Complete { get; set; }
    public int CurrentWeekIndex { get; set; } = 1;
    public MyDayOfWeek CurrentDayOfWeek { get; set; } = MyDayOfWeek.Monday();

    public void AdvanceMesocycleToNextWorkout(IReadOnlyList<Exercise.Exercise> exercises)
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

        if (CurrentWeekIndex > TotalWeeks)
        {
            Complete = true;
        }
        else
        {
            if (GetCurrentWeek().HasNoValue)
            {
                var newWeek = CreateNewWeekBasedOnPreviousWeek(CurrentWeekIndex, exercises);
                Weeks.Add(newWeek);
                //create a new week
            }
        }
    }

    private Maybe<Week> GetCurrentWeek()
    {
        return Weeks.SingleOrDefault(m => m.WeekIndex == CurrentWeekIndex);
    }

    public Maybe<Workout> GetCurrentWorkout()
    {
        if (GetCurrentWeek().HasNoValue)
        {
            return Maybe<Workout>.None;
        }

        return GetCurrentWeek().Value.Workouts.SingleOrDefault(x => x.DayOfWeek == CurrentDayOfWeek);
    }

    public Week CreateNewWeekBasedOnPreviousWeek(int weekIndex, IReadOnlyList<Exercise.Exercise> exercises)
    {
        var weekToDuplicate = Weeks.SingleOrDefault(w => w.WeekIndex == weekIndex - 1);
        
        if (weekToDuplicate == null)
        {
            throw new InvalidOperationException($"Week with WeekIndex {weekIndex} not found in the Mesocycle.");
        }

        if (weekToDuplicate.Workouts.Count == 0)
        {
            throw new InvalidOperationException($"Week with WeekIndex {weekIndex} has no workouts.");
        }

        
        var workoutsForNewWeek = weekToDuplicate.Workouts.Select(workout => new Workout
        (
            workout.DayOfWeek,
            workout.SetGroups.Select(setGroup => new SetGroup
            {
                Priority = setGroup.Priority,
                ExerciseId = setGroup.ExerciseId,
                Sets = setGroup.Sets.Select(set => new Set
                {
                    Weight = set.Weight,
                    Reps = set.Reps,
                    TargetReps = set.TargetReps,
                    TargetWeight = set.TargetWeight,
                }).ToList()

            }).ToList())).ToList();

        foreach (var workout in workoutsForNewWeek)
        {
            foreach (var setGroup in workout.SetGroups)
            {
                var exercise = exercises.SingleOrDefault(e => e.Id == setGroup.ExerciseId);
                if (exercise == null)
                {
                    throw new InvalidOperationException($"Exercise with Id {setGroup.ExerciseId} not found in the list of exercises.");
                }
                foreach (var set in setGroup.Sets)
                {
                        set.TargetWeight = set.Weight + (exercise.BodyWeightExercise ? 0 : exercise.WeightIncrease);
                    set.TargetReps = set.Reps + (exercise.BodyWeightExercise ? exercise.RepIncrease : 0);
                    set.Weight = set.TargetWeight;
                    set.TargetReps = set.Reps;
                }
            }
        }

        var newWeek = new Week(weekIndex, workoutsForNewWeek);

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
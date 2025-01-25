using TrackMyMacros.Attributes;
using TrackMyMacros.Domain.Common;
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

    public void FinishWorkout()
    {
        if (CurrentDayOfWeek == MyDayOfWeek.Friday())
        {
            CurrentDayOfWeek = MyDayOfWeek.Monday();
            CurrentWeekIndex++;
        }
        else if (CurrentDayOfWeek == MyDayOfWeek.Monday())
        {
            CurrentDayOfWeek = MyDayOfWeek.Wednesday();
            CurrentWeekIndex++;
        }
        else
        {
            CurrentDayOfWeek = MyDayOfWeek.Friday();
        }
    }
    
    private Week GetCurrentWeek()
    {
        return Weeks.Single(m=>m.WeekIndex==CurrentWeekIndex);
    }

    public Workout GetCurrentWorkout()
    {
        return GetCurrentWeek().Workouts.Single(x => x.DayOfWeek == CurrentDayOfWeek);
    }
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
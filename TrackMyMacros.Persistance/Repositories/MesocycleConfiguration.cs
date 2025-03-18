using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.Aggregates;
using TrackMyMacros.Domain.Aggregates.Exercise;
using TrackMyMacros.Domain.Aggregates.Mesocycle;
using TrackMyMacros.Domain.ValueObjects;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Persistance.Repositories;

public class MesocycleConfiguration : IEntityTypeConfiguration<Mesocycle>
{
    public void Configure(EntityTypeBuilder<Mesocycle> builder)
    {
        builder.Property(p => p.Id)
            .IsRequired()
            .HasIdentityOptions(startValue: 100);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(50);


        builder.Property(m => m.CurrentDayOfWeek).HasConversion(m => m.Value()
            , w => new MyDayOfWeek(w));
        Guid mesoId = Guid.NewGuid();
        int WeekId = 1;
        int mondayExerciseDayId = 1;
        int wednesdayExerciseDayId = 2;
        int fridayExerciseDayId = 3;


        builder.OwnsMany(m => m.Weeks,
            Week =>
            {
                Week.WithOwner().HasForeignKey("MesocycleId");
                Week.Property(m => m.WeekIndex);
                Week.OwnsMany<Workout>(n => n.Workouts,
                    workout =>
                    {
                        workout.Property(m => m.DayOfWeek)
                            .HasConversion(m => m.Value()
                                , w => new MyDayOfWeek(w));
                        workout.OwnsMany<SetGroup>(m => m.SetGroups,
                            setGroup =>
                            {
                                setGroup.Property(m => m.Priority);
                                setGroup.Property(m => m.ExerciseId);
                                setGroup.Navigation(m => m.Exercise).AutoInclude();    
                                setGroup.OwnsMany<Set>(m => m.Sets,
                                    set =>
                                    {
                                        set.Property(ex => ex.Weight);
                                        set.Property(ex => ex.TargetReps);
                                        set.Property(ex => ex.Reps);
                                        set.Property(ex => ex.TargetWeight);


                                        set.HasData(SeedSets(mesoId, mondayExerciseDayId, wednesdayExerciseDayId,
                                            fridayExerciseDayId));
                                    });
                                    
                                    setGroup.HasData(SeedSetGroups(mesoId, mondayExerciseDayId, wednesdayExerciseDayId,
                                        fridayExerciseDayId));
                            });

                        workout.HasData(
                            SeedWeekDays(mesoId, WeekId, mondayExerciseDayId, wednesdayExerciseDayId,
                                fridayExerciseDayId));
                    });

                Week.HasData(new { MesocycleId = mesoId, Id = 1, WeekIndex = 1 });
            }
        );

        // Seed data
        builder.HasData(new
        {
            Id = mesoId, Name = "Default Mesocycle", CurrentWeekIndex = 1, CurrentDayOfWeek = MyDayOfWeek.Monday(),
            TotalWeeks = 5, Complete = false,
            CreatedDate = DateTime.Now.ToUniversalTime(),
            CreatedBy = "System", UpdatedDate = DateTime.Now.ToUniversalTime(), UpdatedBy = "System"
        });


        //
        // var readOnlyList = SeedData.Foods();
        // builder.HasData(readOnlyList);
    }

    private static List<object> SeedWeekDays(Guid mesoId, int WeekId, int mondayExerciseDayId,
        int wednesdayExerciseDayId, int fridayExerciseDayId)
    {
        return new List<object>()
        {
            new
            {
                WeekMesocycleId = mesoId,
                WeekId = WeekId, Id = mondayExerciseDayId, DayOfWeek = MyDayOfWeek.Monday(), Complete = false
            },
            new
            {
                WeekMesocycleId = mesoId,
                WeekId = WeekId, Id = wednesdayExerciseDayId, DayOfWeek = MyDayOfWeek.Wednesday(), Complete = false
            },
            new
            {
                WeekMesocycleId = mesoId,
                WeekId = WeekId, Id = fridayExerciseDayId, DayOfWeek = MyDayOfWeek.Friday(),
                Complete = false,
            }
        };
    }

private static int MondayInclineDumbbellPressSetGroupGuid = 1;
private static int MondayPullDownSetGroupGuid = 2;
private static int MondaySquatSetGroupGuid = 3;
private static int MondayCalvesTwoSecondPauseSetGroupGuid = 4;
private static int MondayLyingDumbellBicepCurlSetGroupGuid = 5;
private static int MondayLyingOverheadTricepsExtensionSetGroupGuid = 6;
private static int MondayReverseNordicsSetGroupGuid = 7;
private static int MondaySingleArmCableLateralRaiseSetGroupGuid = 8;
private static int MondayCableCrunchSetGroupGuid = 9;
private static int WednesdayFlyesSetGroupGuid = 10;
private static int WednesdayDualCableRowSetGroupGuid = 11;
private static int WednesdayRDLSetGroupGuid = 12;
private static int WednesdayCalvesFourSecondEccentricSetGroupGuid = 13;
private static int WednesdayLyingDumbellBicepCurlSetGroupGuid = 14;
private static int WednesdayLyingOverheadTricepsExtensionSetGroupGuid = 15;
private static int WednesdayReverseNordicsSetGroupGuid = 16;
private static int WednesdaySingleArmCableLateralRaiseSetGroupGuid = 17;
private static int WednesdayCableCrunchSetGroupGuid = 18;
private static int FridayFlyesSetGroupGuid = 19;
private static int FridayPullDownSetGroupGuid = 20;
private static int FridayRDLSetGroupGuid = 21;
private static int FridayCalvesTwoSecondPauseSetGroupGuid = 22;
private static int FridayLyingDumbellBicepCurlSetGroupGuid = 23;
private static int FridayLyingOverheadTricepsExtensionSetGroupGuid = 24;
private static int FridayReverseNordicsSetGroupGuid = 25;
private static int FridaySingleArmCableLateralRaiseSetGroupGuid = 26;
private static int FridayCableCrunchSetGroupGuid = 27;


private static List<object> SeedSetGroups(Guid mesoId, int mondayExerciseDayId, int wednesdayExerciseDayId,
    int fridayExerciseDayId)
{
    return new List<object>()
    {
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = mondayExerciseDayId, Id = 1, Priority = 1,
            SetGroupId = MondayInclineDumbbellPressSetGroupGuid,
            ExerciseId = Exercise.InclineDumbbellPress().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = mondayExerciseDayId, Id = 2, Priority = 2,
            SetGroupId = MondayPullDownSetGroupGuid,
            ExerciseId = Exercise.PullDown().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = mondayExerciseDayId, Id = 3, Priority = 3,
            SetGroupId = MondaySquatSetGroupGuid,
            ExerciseId = Exercise.Squat().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = mondayExerciseDayId, Id = 4, Priority = 4,
            SetGroupId = MondayCalvesTwoSecondPauseSetGroupGuid,
            ExerciseId = Exercise.CalvesTwoSecondPause().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = mondayExerciseDayId, Id = 5, Priority = 5,
            SetGroupId = MondayLyingDumbellBicepCurlSetGroupGuid,
            ExerciseId = Exercise.LyingDumbellBicepCurl().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = mondayExerciseDayId, Id = 6, Priority = 6,
            SetGroupId = MondayLyingOverheadTricepsExtensionSetGroupGuid,
            ExerciseId = Exercise.LyingOverheadTricepsExtension().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = mondayExerciseDayId, Id = 7, Priority = 7,
            SetGroupId = MondayReverseNordicsSetGroupGuid,
            ExerciseId = Exercise.ReverseNordics().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = mondayExerciseDayId, Id = 8, Priority = 8,
            SetGroupId = MondaySingleArmCableLateralRaiseSetGroupGuid,
            ExerciseId = Exercise.SingleArmCableLateralRaise().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = mondayExerciseDayId, Id = 9, Priority = 9,
            SetGroupId = MondayCableCrunchSetGroupGuid,
            ExerciseId = Exercise.CableCrunch().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = wednesdayExerciseDayId, Id = 10, Priority = 1,
            SetGroupId = WednesdayFlyesSetGroupGuid,
            ExerciseId = Exercise.Flyes().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = wednesdayExerciseDayId, Id = 11, Priority = 2,
            SetGroupId = WednesdayDualCableRowSetGroupGuid,
            ExerciseId = Exercise.DualCableRow().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = wednesdayExerciseDayId, Id = 12, Priority = 3,
            SetGroupId = WednesdayRDLSetGroupGuid,
            ExerciseId = Exercise.RDL().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = wednesdayExerciseDayId, Id = 13, Priority = 4,
            SetGroupId = WednesdayCalvesFourSecondEccentricSetGroupGuid,
            ExerciseId = Exercise.CalvesFourSecondEccentric().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = wednesdayExerciseDayId, Id = 14, Priority = 5,
            SetGroupId = WednesdayLyingDumbellBicepCurlSetGroupGuid,
            ExerciseId = Exercise.LyingDumbellBicepCurl().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = wednesdayExerciseDayId, Id = 15, Priority = 6,
            SetGroupId = WednesdayLyingOverheadTricepsExtensionSetGroupGuid,
            ExerciseId = Exercise.LyingOverheadTricepsExtension().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = wednesdayExerciseDayId, Id = 16, Priority = 7,
            SetGroupId = WednesdayReverseNordicsSetGroupGuid,
            ExerciseId = Exercise.ReverseNordics().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = wednesdayExerciseDayId, Id = 17, Priority = 8,
            SetGroupId = WednesdaySingleArmCableLateralRaiseSetGroupGuid,
            ExerciseId = Exercise.SingleArmCableLateralRaise().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = wednesdayExerciseDayId, Id = 18, Priority = 9,
            SetGroupId = WednesdayCableCrunchSetGroupGuid,
            ExerciseId = Exercise.CableCrunch().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = fridayExerciseDayId, Id = 19, Priority = 1,
            SetGroupId = FridayFlyesSetGroupGuid,
            ExerciseId = Exercise.Flyes().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = fridayExerciseDayId, Id = 20, Priority = 2,
            SetGroupId = FridayPullDownSetGroupGuid,
            ExerciseId = Exercise.PullDown().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = fridayExerciseDayId, Id = 21, Priority = 3,
            SetGroupId = FridayRDLSetGroupGuid,
            ExerciseId = Exercise.RDL().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = fridayExerciseDayId, Id = 22, Priority = 4,
            SetGroupId = FridayCalvesTwoSecondPauseSetGroupGuid,
            ExerciseId = Exercise.CalvesTwoSecondPause().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = fridayExerciseDayId, Id = 23, Priority = 5,
            SetGroupId = FridayLyingDumbellBicepCurlSetGroupGuid,
            ExerciseId = Exercise.LyingDumbellBicepCurl().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = fridayExerciseDayId, Id = 24, Priority = 6,
            SetGroupId = FridayLyingOverheadTricepsExtensionSetGroupGuid,
            ExerciseId = Exercise.LyingOverheadTricepsExtension().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = fridayExerciseDayId, Id = 25, Priority = 7,
            SetGroupId = FridayReverseNordicsSetGroupGuid,
            ExerciseId = Exercise.ReverseNordics().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = fridayExerciseDayId, Id = 26, Priority = 8,
            SetGroupId = FridaySingleArmCableLateralRaiseSetGroupGuid,
            ExerciseId = Exercise.SingleArmCableLateralRaise().Id
        },
        new
        {
            WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            WorkoutId = fridayExerciseDayId, Id = 27, Priority = 9,
            SetGroupId = FridayCableCrunchSetGroupGuid,
            ExerciseId = Exercise.CableCrunch().Id
        }
    };
}

private static List<object> SeedSets(Guid mesoId, int mondayExerciseDayId, int wednesdayExerciseDayId,
        int fridayExerciseDayId)
    {
        return new List<object>()
        {
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = mondayExerciseDayId, Id = 1, Weight = 10D, Reps = 0, TargetReps = 14,
                TargetWeight = 21D, SetGroupId = MondayInclineDumbbellPressSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = mondayExerciseDayId, Id = 2, Weight = 10D, Reps = 0, TargetReps = 12,
                TargetWeight = 51.5D, SetGroupId = MondayPullDownSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = mondayExerciseDayId, Id = 3, Weight = 10D, Reps = 0, TargetReps = 8,
                TargetWeight = 52.5D, SetGroupId = MondaySquatSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = mondayExerciseDayId, Id = 4, Weight = 10D, Reps = 0, TargetReps = 11,
                TargetWeight = 42D, SetGroupId = MondayCalvesTwoSecondPauseSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = mondayExerciseDayId, Id = 5, Weight = 10D, Reps = 0, TargetReps = 8,
                TargetWeight = 9D, SetGroupId = MondayLyingDumbellBicepCurlSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = mondayExerciseDayId, Id = 6, Weight = 10D, Reps = 0, TargetReps = 8,
                TargetWeight = 14.5D, SetGroupId = MondayLyingOverheadTricepsExtensionSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = mondayExerciseDayId, Id = 7, Weight = 10D, Reps = 0, TargetReps = 5,
                TargetWeight = 100D, SetGroupId = MondayReverseNordicsSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = mondayExerciseDayId, Id = 8, Weight = 10D, Reps = 0, TargetReps = 7,
                TargetWeight = 14.5D, SetGroupId = MondaySingleArmCableLateralRaiseSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = mondayExerciseDayId, Id = 9, Weight = 10D, Reps = 0, TargetReps = 6,
                TargetWeight = 14.5D, SetGroupId = MondayCableCrunchSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = wednesdayExerciseDayId, Id = 10, Weight = 16.75D, Reps = 0, TargetReps = 14,
                TargetWeight = 16.75, SetGroupId = WednesdayFlyesSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = wednesdayExerciseDayId, Id = 11, Weight = 24.5D, Reps = 0, TargetReps = 10,
                TargetWeight = 24.5D, SetGroupId = WednesdayDualCableRowSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = wednesdayExerciseDayId, Id = 12, Weight = 47.25D, Reps = 0, TargetReps = 9,
                TargetWeight = 47.25D, SetGroupId = WednesdayRDLSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = wednesdayExerciseDayId, Id = 13, Weight = 10D, Reps = 0, TargetReps = 7,
                TargetWeight = 47.25D, SetGroupId = WednesdayCalvesFourSecondEccentricSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = wednesdayExerciseDayId, Id = 14, Weight = 10.5D, Reps = 0, TargetReps = 8,
                TargetWeight = 10.5D, SetGroupId = WednesdayLyingDumbellBicepCurlSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = wednesdayExerciseDayId, Id = 15, Weight = 10D, Reps = 0, TargetReps = 8,
                TargetWeight = 14.75D, SetGroupId = WednesdayLyingOverheadTricepsExtensionSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = wednesdayExerciseDayId, Id = 16, Weight = 10D, Reps = 0, TargetReps = 5,
                TargetWeight = 100D, SetGroupId = WednesdayReverseNordicsSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = wednesdayExerciseDayId, Id = 17, Weight = 10D, Reps = 0, TargetReps = 7,
                TargetWeight = 14.75D, SetGroupId = WednesdaySingleArmCableLateralRaiseSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = wednesdayExerciseDayId, Id = 18, Weight = 10D, Reps = 0, TargetReps = 6,
                TargetWeight = 14.75D, SetGroupId = WednesdayCableCrunchSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = fridayExerciseDayId, Id = 19, Weight = 10D, Reps = 0, TargetReps = 14,
                TargetWeight = 16.75D, SetGroupId = FridayFlyesSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = fridayExerciseDayId, Id = 20, Weight = 10D, Reps = 0, TargetReps = 14,
                TargetWeight = 51.45D, SetGroupId = FridayPullDownSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = fridayExerciseDayId, Id = 21, Weight = 10D, Reps = 0, TargetReps = 9,
                TargetWeight = 47.25D, SetGroupId = FridayRDLSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = fridayExerciseDayId, Id = 22, Weight = 10D, Reps = 0, TargetReps = 10,
                TargetWeight = 47.25D, SetGroupId = FridayCalvesTwoSecondPauseSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = fridayExerciseDayId, Id = 23, Weight = 10D, Reps = 0, TargetReps = 8,
                TargetWeight = 10.5D, SetGroupId = FridayLyingDumbellBicepCurlSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = fridayExerciseDayId, Id = 24, Weight = 10D, Reps = 0, TargetReps = 10,
                TargetWeight = 14.75D, SetGroupId = FridayLyingOverheadTricepsExtensionSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = fridayExerciseDayId, Id = 25, Weight = 10D, Reps = 0, TargetReps = 5,
                TargetWeight = 100D, SetGroupId = FridayReverseNordicsSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = fridayExerciseDayId, Id = 26, Weight = 10D, Reps = 0, TargetReps = 7,
                TargetWeight = 14.75D, SetGroupId = FridaySingleArmCableLateralRaiseSetGroupGuid, Number = 1
            },
            new
            {
                SetGroupWorkoutWeekMesocycleId = mesoId, SetGroupWorkoutWeekId = 1,
                SetGroupWorkoutId = fridayExerciseDayId, Id = 27, Weight = 10D, Reps = 0, TargetReps = 6,
                TargetWeight = 14.75D, SetGroupId = FridayCableCrunchSetGroupGuid, Number = 1
            }
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = mondayExerciseDayId, Id = 1, Weight = 10D, Reps = 0, TargetReps = 14,
            //         TargetWeight = 21D,
            //         ExerciseId = Exercise.InclineDumbbellPress().Id, Priority = 1, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = mondayExerciseDayId, Id = 2, Weight = 10D, Reps = 0, TargetReps = 12,
            //         TargetWeight = 51.5D,
            //         ExerciseId = Exercise.PullDown().Id, Priority = 2, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = mondayExerciseDayId, Id = 3, Weight = 10D, Reps = 0, TargetReps = 8,
            //         TargetWeight = 52.5D,
            //         ExerciseId = Exercise.Squat().Id, Priority = 3, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = mondayExerciseDayId, Id = 4, Weight = 10D, Reps = 0, TargetReps = 11,
            //         TargetWeight = 42D,
            //         ExerciseId = Exercise.CalvesTwoSecondPause().Id, Priority = 4, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = mondayExerciseDayId, Id = 5, Weight = 10D, Reps = 0, TargetReps = 8, TargetWeight = 9D,
            //         ExerciseId = Exercise.LyingDumbellBicepCurl().Id, Priority = 5, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = mondayExerciseDayId, Id = 6, Weight = 10D, Reps = 0, TargetReps = 8,
            //         TargetWeight = 14.5D,
            //         ExerciseId = Exercise.LyingOverheadTricepsExtension().Id, Priority = 6, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = mondayExerciseDayId, Id = 7, Weight = 10D, Reps = 0, TargetReps = 5,
            //         TargetWeight = 100D,
            //         ExerciseId = Exercise.ReverseNordics().Id, Priority = 7, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = mondayExerciseDayId, Id = 8, Weight = 10D, Reps = 0, TargetReps = 7,
            //         TargetWeight = 14.5D,
            //         ExerciseId = Exercise.SingleArmCableLateralRaise().Id, Priority = 8, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = mondayExerciseDayId, Id = 9, Weight = 10D, Reps = 0, TargetReps = 6,
            //         TargetWeight = 14.5D,
            //         ExerciseId = Exercise.CableCrunch().Id, Priority = 9, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = wednesdayExerciseDayId, Id = 10, Weight = 16.75D, Reps = 0, TargetReps = 14,
            //         TargetWeight = 16.75, ExerciseId = Exercise.Flyes().Id, Priority = 1, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = wednesdayExerciseDayId, Id = 11, Weight = 24.5D, Reps = 0, TargetReps = 10,
            //         TargetWeight = 24.5D, ExerciseId = Exercise.DualCableRow().Id, Priority = 2, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = wednesdayExerciseDayId, Id = 12, Weight = 47.25D, Reps = 0, TargetReps = 9,
            //         TargetWeight = 47.25D,
            //         ExerciseId = Exercise.RDL().Id, Priority = 3, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = wednesdayExerciseDayId, Id = 13, Weight = 10D, Reps = 0, TargetReps = 7,
            //         TargetWeight = 47.25D, ExerciseId = Exercise.CalvesFourSecondEccentric().Id, Priority = 4,
            //         Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = wednesdayExerciseDayId, Id = 14, Weight = 10.5D, Reps = 0, TargetReps = 8,
            //         TargetWeight = 10.5D,
            //         ExerciseId = Exercise.LyingDumbellBicepCurl().Id, Priority = 5, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = wednesdayExerciseDayId, Id = 15, Weight = 10D, Reps = 0, TargetReps = 8,
            //         TargetWeight = 14.75D, ExerciseId = Exercise.LyingOverheadTricepsExtension().Id, Priority = 6,
            //         Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = wednesdayExerciseDayId, Id = 16, Weight = 10D, Reps = 0, TargetReps = 5,
            //         TargetWeight = 100D, ExerciseId = Exercise.ReverseNordics().Id, Priority = 7, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = wednesdayExerciseDayId, Id = 17, Weight = 10D, Reps = 0, TargetReps = 7,
            //         TargetWeight = 14.75D,
            //         ExerciseId = Exercise.SingleArmCableLateralRaise().Id, Priority = 8, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = wednesdayExerciseDayId, Id = 18, Weight = 10D, Reps = 0, TargetReps = 6,
            //         TargetWeight = 14.75D,
            //         ExerciseId = Exercise.CableCrunch().Id, Priority = 9, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = fridayExerciseDayId, Id = 19, Weight = 10D, Reps = 0, TargetReps = 14,
            //         TargetWeight = 16.75D,
            //         ExerciseId = Exercise.Flyes().Id, Priority = 1, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = fridayExerciseDayId, Id = 20, Weight = 10D, Reps = 0, TargetReps = 14,
            //         TargetWeight = 51.45D,
            //         ExerciseId = Exercise.PullDown().Id, Priority = 2, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = fridayExerciseDayId, Id = 21, Weight = 10D, Reps = 0, TargetReps = 9,
            //         TargetWeight = 47.25D,
            //         ExerciseId = Exercise.RDL().Id, Priority = 3, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = fridayExerciseDayId, Id = 22, Weight = 10D, Reps = 0, TargetReps = 10,
            //         TargetWeight = 47.25D,
            //         ExerciseId = Exercise.CalvesTwoSecondPause().Id, Priority = 4, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = fridayExerciseDayId, Id = 23, Weight = 10D, Reps = 0, TargetReps = 8,
            //         TargetWeight = 10.5D,
            //         ExerciseId = Exercise.LyingDumbellBicepCurl().Id, Priority = 5, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = fridayExerciseDayId, Id = 24, Weight = 10D, Reps = 0, TargetReps = 10,
            //         TargetWeight = 14.75D,
            //         ExerciseId = Exercise.LyingOverheadTricepsExtension().Id, Priority = 6, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = fridayExerciseDayId, Id = 25, Weight = 10D, Reps = 0, TargetReps = 5,
            //         TargetWeight = 100D,
            //         ExerciseId = Exercise.ReverseNordics().Id, Priority = 7, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = fridayExerciseDayId, Id = 26, Weight = 10D, Reps = 0, TargetReps = 7,
            //         TargetWeight = 14.75D,
            //         ExerciseId = Exercise.SingleArmCableLateralRaise().Id, Priority = 8, Number = 1
            //     },
            //     new
            //     {
            //         WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
            //         WorkoutId = fridayExerciseDayId, Id = 27, Weight = 10D, Reps = 0, TargetReps = 6,
            //         TargetWeight = 14.75D,
            //         ExerciseId = Exercise.CableCrunch().Id, Priority = 9, Number = 1
            //     },
            // };
        };
    }
}
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
                        workout.OwnsMany<Set>(m => m.Sets,
                            set =>
                            {
                                set.Property(ex => ex.Weight);
                                set.Property(ex => ex.TargetReps);
                                set.Property(ex => ex.Reps);
                                set.Property(ex => ex.TargetWeight);
                                set.Navigation(ex => ex.Exercise)
                                    .AutoInclude();
                                // exerciseSet.Property(ex => ex.Exercise);

                                set.HasData(SeedExerciseSets(mesoId, mondayExerciseDayId, wednesdayExerciseDayId,
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

    private static List<object> SeedExerciseSets(Guid mesoId, int mondayExerciseDayId, int wednesdayExerciseDayId,
        int fridayExerciseDayId)
    {
        return new List<object>()
        {
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = mondayExerciseDayId, Id = 1, Weight = 10D, Reps = 0, TargetReps = 14, TargetWeight = 20D,
                ExerciseId = Exercise.InclineDumbbellPress().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = mondayExerciseDayId, Id = 2, Weight = 10D, Reps = 0, TargetReps = 12, TargetWeight = 49D,
                ExerciseId = Exercise.PullDown().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = mondayExerciseDayId, Id = 3, Weight = 10D, Reps = 0, TargetReps = 8, TargetWeight = 5D,
                ExerciseId = Exercise.Squat().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = mondayExerciseDayId, Id = 4, Weight = 10D, Reps = 0, TargetReps = 10, TargetWeight = 40D,
                ExerciseId = Exercise.CalvesTwoSecondPause().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = mondayExerciseDayId, Id = 5, Weight = 10D, Reps = 0, TargetReps = 8, TargetWeight = 9D,
                ExerciseId = Exercise.LyingDumbellBicepCurl().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = mondayExerciseDayId, Id = 6, Weight = 10D, Reps = 0, TargetReps = 10, TargetWeight = 17D,
                ExerciseId = Exercise.LyingOverheadTricepsExtension().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = mondayExerciseDayId, Id = 7, Weight = 10D, Reps = 0, TargetReps = 3, TargetWeight = 100D,
                ExerciseId = Exercise.ReverseNordics().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = mondayExerciseDayId, Id = 8, Weight = 10D, Reps = 0, TargetReps = 7, TargetWeight = 15D,
                ExerciseId = Exercise.SingleArmCableLateralRaise().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = mondayExerciseDayId, Id = 9, Weight = 10D, Reps = 0, TargetReps = 5, TargetWeight = 10D,
                ExerciseId = Exercise.CableCrunch().Id
            },

            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = wednesdayExerciseDayId, Id = 10, Weight = 10D, Reps = 0, TargetReps = 14,
                TargetWeight = 20D, ExerciseId = Exercise.InclineDumbbellPress().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = wednesdayExerciseDayId, Id = 11, Weight = 10D, Reps = 0, TargetReps = 10,
                TargetWeight = 46.5D, ExerciseId = Exercise.DualCableRow().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = wednesdayExerciseDayId, Id = 12, Weight = 10D, Reps = 0, TargetReps = 9, TargetWeight = 45D,
                ExerciseId = Exercise.RDL().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = wednesdayExerciseDayId, Id = 13, Weight = 10D, Reps = 0, TargetReps = 8,
                TargetWeight = 41.5D, ExerciseId = Exercise.CalvesFourSecondEccentric().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = wednesdayExerciseDayId, Id = 14, Weight = 10D, Reps = 0, TargetReps = 8, TargetWeight = 9D,
                ExerciseId = Exercise.LyingDumbellBicepCurl().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = wednesdayExerciseDayId, Id = 15, Weight = 10D, Reps = 0, TargetReps = 10,
                TargetWeight = 17D, ExerciseId = Exercise.LyingOverheadTricepsExtension().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = wednesdayExerciseDayId, Id = 16, Weight = 10D, Reps = 0, TargetReps = 3,
                TargetWeight = 100D, ExerciseId = Exercise.ReverseNordics().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = wednesdayExerciseDayId, Id = 17, Weight = 10D, Reps = 0, TargetReps = 7, TargetWeight = 15D,
                ExerciseId = Exercise.SingleArmCableLateralRaise().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = wednesdayExerciseDayId, Id = 18, Weight = 10D, Reps = 0, TargetReps = 5, TargetWeight = 10D,
                ExerciseId = Exercise.CableCrunch().Id
            },

            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = fridayExerciseDayId, Id = 19, Weight = 10D, Reps = 0, TargetReps = 15, TargetWeight = 16D,
                ExerciseId = Exercise.Flyes().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = fridayExerciseDayId, Id = 20, Weight = 10D, Reps = 0, TargetReps = 12, TargetWeight = 49D,
                ExerciseId = Exercise.PullDown().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = fridayExerciseDayId, Id = 21, Weight = 10D, Reps = 0, TargetReps = 9, TargetWeight = 45D,
                ExerciseId = Exercise.RDL().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = fridayExerciseDayId, Id = 22, Weight = 10D, Reps = 0, TargetReps = 10, TargetWeight = 40D,
                ExerciseId = Exercise.CalvesTwoSecondPause().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = fridayExerciseDayId, Id = 23, Weight = 10D, Reps = 0, TargetReps = 8, TargetWeight = 9D,
                ExerciseId = Exercise.LyingDumbellBicepCurl().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = fridayExerciseDayId, Id = 24, Weight = 10D, Reps = 0, TargetReps = 10, TargetWeight = 17D,
                ExerciseId = Exercise.LyingOverheadTricepsExtension().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = fridayExerciseDayId, Id = 25, Weight = 10D, Reps = 0, TargetReps = 3, TargetWeight = 100D,
                ExerciseId = Exercise.ReverseNordics().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = fridayExerciseDayId, Id = 26, Weight = 10D, Reps = 0, TargetReps = 7, TargetWeight = 15D,
                ExerciseId = Exercise.SingleArmCableLateralRaise().Id
            },
            new
            {
                WorkoutWeekMesocycleId = mesoId, WorkoutWeekId = 1,
                WorkoutId = fridayExerciseDayId, Id = 27, Weight = 10D, Reps = 0, TargetReps = 5, TargetWeight = 10D,
                ExerciseId = Exercise.CableCrunch().Id
            },
        };
    }
}
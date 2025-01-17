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

        Guid mesoId = Guid.NewGuid();
        int MesocycleWeekId = 1;
        int mondayExerciseDayId = 1;
        int wednesdayExerciseDayId = 2;
        int fridayExerciseDayId = 3;


        builder.OwnsMany(m => m.MesocycleWeeks,
            mesocycleWeek =>
            {
                mesocycleWeek.WithOwner().HasForeignKey("MesocycleId");
                mesocycleWeek.Property(m => m.WeekIndex);
                mesocycleWeek.OwnsMany<MesocycleWeekDay>(n => n.MesocycleWeekDays,
                    mesocycleWeekDay =>
                    {
                        mesocycleWeekDay.Property(m => m.DayOfWeek)
                            .HasConversion(m => m.Value()
                                , w => new MyDayOfWeek(w));
                        mesocycleWeekDay.OwnsMany<ExerciseDaySet>(m => m.ExerciseDaySets,
                            exerciseSet =>
                            {
                                exerciseSet.Property(ex => ex.ExerciseId);
                                exerciseSet.Property(ex => ex.TargetReps);
                                exerciseSet.Property(ex => ex.Reps);
                                exerciseSet.Property(ex => ex.TargetWeight);

                                exerciseSet.HasData(SeedExerciseSets(mesoId, mondayExerciseDayId, wednesdayExerciseDayId,
                                    fridayExerciseDayId));
                            });

                        mesocycleWeekDay.HasData(
                            SeedMesocycleWeekDays(mesoId, MesocycleWeekId, mondayExerciseDayId, wednesdayExerciseDayId, fridayExerciseDayId));
                    });
                
                mesocycleWeek.HasData(new {MesocycleId = mesoId,  Id = 1, WeekIndex = 1});
            }
        );
        
        // Seed data
        builder.HasData(new {Id = mesoId, Name = "Default Mesocycle", CreatedDate = DateTime.Now.ToUniversalTime(),
            CreatedBy = "System", UpdatedDate = DateTime.Now.ToUniversalTime(), UpdatedBy = "System"});


        //
        // var readOnlyList = SeedData.Foods();
        // builder.HasData(readOnlyList);
    }

    private static List<object> SeedMesocycleWeekDays(Guid mesoId, int mesocycleWeekId, int mondayExerciseDayId, int wednesdayExerciseDayId, int fridayExerciseDayId)
    {
        return new List<object>()
        {
            new
            {
                MesocycleWeekMesocycleId = mesoId,
                MesocycleWeekId = mesocycleWeekId, Id = mondayExerciseDayId, DayOfWeek = MyDayOfWeek.Monday(), Complete=false
            },
            new
            {
                MesocycleWeekMesocycleId = mesoId,
                MesocycleWeekId = mesocycleWeekId, Id = wednesdayExerciseDayId, DayOfWeek = MyDayOfWeek.Wednesday(), Complete=false
            },
            new
            {
                MesocycleWeekMesocycleId = mesoId,
                MesocycleWeekId = mesocycleWeekId, Id = fridayExerciseDayId, DayOfWeek = MyDayOfWeek.Friday(),
                 Complete=false,
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
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = mondayExerciseDayId,Id =1 ,Reps = 0, TargetReps = 14, TargetWeight = 20D,
                ExerciseId = Exercise.InclineDumbbellPress().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = mondayExerciseDayId,Id = 2,Reps = 0, TargetReps = 12, TargetWeight = 49D,
                ExerciseId = Exercise.PullDown().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = mondayExerciseDayId, Id =3 ,Reps = 0, TargetReps = 8, TargetWeight = 5D,
                ExerciseId = Exercise.Squat().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = mondayExerciseDayId, Id = 4,Reps = 0, TargetReps = 10, TargetWeight = 40D,
                ExerciseId = Exercise.CalvesTwoSecondPause().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = mondayExerciseDayId, Id = 5,Reps = 0, TargetReps = 8, TargetWeight = 9D,
                ExerciseId = Exercise.LyingDumbellBicepCurl().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = mondayExerciseDayId, Id = 6,Reps = 0, TargetReps = 10, TargetWeight = 17D,
                ExerciseId = Exercise.LyingOverheadTricepsExtension().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = mondayExerciseDayId, Id = 7,Reps = 0, TargetReps = 3, TargetWeight = 100D,
                ExerciseId = Exercise.ReverseNordics().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = mondayExerciseDayId, Id =8 ,Reps = 0, TargetReps = 7, TargetWeight = 15D,
                ExerciseId = Exercise.SingleArmCableLateralRaise().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = mondayExerciseDayId, Id = 9,Reps = 0, TargetReps = 5, TargetWeight = 10D,
                ExerciseId = Exercise.CableCrunch().Id
            },

            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = wednesdayExerciseDayId, Id = 10,Reps = 0, TargetReps = 14,
                TargetWeight = 20D, ExerciseId = Exercise.InclineDumbbellPress().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = wednesdayExerciseDayId, Id =11 ,Reps = 0, TargetReps = 10,
                TargetWeight = 46.5D, ExerciseId = Exercise.DualCableRow().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = wednesdayExerciseDayId, Id = 12,Reps = 0, TargetReps = 9, TargetWeight = 45D,
                ExerciseId = Exercise.RDL().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = wednesdayExerciseDayId, Id =13 ,Reps = 0, TargetReps = 8,
                TargetWeight = 41.5D, ExerciseId = Exercise.CalvesFourSecondEccentric().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = wednesdayExerciseDayId, Id =14 ,Reps = 0, TargetReps = 8, TargetWeight = 9D,
                ExerciseId = Exercise.LyingDumbellBicepCurl().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = wednesdayExerciseDayId, Id =15 ,Reps = 0, TargetReps = 10,
                TargetWeight = 17D, ExerciseId = Exercise.LyingOverheadTricepsExtension().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = wednesdayExerciseDayId, Id =16 ,Reps = 0, TargetReps = 3,
                TargetWeight = 100D, ExerciseId = Exercise.ReverseNordics().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = wednesdayExerciseDayId, Id =17 ,Reps = 0, TargetReps = 7, TargetWeight = 15D,
                ExerciseId = Exercise.SingleArmCableLateralRaise().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = wednesdayExerciseDayId, Id =18 ,Reps = 0, TargetReps = 5, TargetWeight = 10D,
                ExerciseId = Exercise.CableCrunch().Id
            },

            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = fridayExerciseDayId, Id = 19,Reps = 0, TargetReps = 15, TargetWeight = 16D,
                ExerciseId = Exercise.Flyes().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = fridayExerciseDayId, Id = 20,Reps = 0, TargetReps = 12, TargetWeight = 49D,
                ExerciseId = Exercise.PullDown().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = fridayExerciseDayId, Id = 21,Reps = 0, TargetReps = 9, TargetWeight = 45D,
                ExerciseId = Exercise.RDL().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = fridayExerciseDayId, Id = 22,Reps = 0, TargetReps = 10, TargetWeight = 40D,
                ExerciseId = Exercise.CalvesTwoSecondPause().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = fridayExerciseDayId, Id = 23,Reps = 0, TargetReps = 8, TargetWeight = 9D,
                ExerciseId = Exercise.LyingDumbellBicepCurl().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = fridayExerciseDayId, Id = 24,Reps = 0, TargetReps = 10, TargetWeight = 17D,
                ExerciseId = Exercise.LyingOverheadTricepsExtension().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = fridayExerciseDayId, Id = 25,Reps = 0, TargetReps = 3, TargetWeight = 100D,
                ExerciseId = Exercise.ReverseNordics().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = fridayExerciseDayId, Id =26 ,Reps = 0, TargetReps = 7, TargetWeight = 15D,
                ExerciseId = Exercise.SingleArmCableLateralRaise().Id
            },
            new
            {
                MesocycleWeekDayMesocycleWeekMesocycleId = mesoId, MesocycleWeekDayMesocycleWeekId = 1,
                MesocycleWeekDayId = fridayExerciseDayId, Id = 27,Reps = 0, TargetReps = 5, TargetWeight = 10D,
                ExerciseId = Exercise.CableCrunch().Id
            },
        };
    }
}
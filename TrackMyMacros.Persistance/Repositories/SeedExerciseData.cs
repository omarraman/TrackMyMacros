using TrackMyMacros.Application.Features;
using TrackMyMacros.Domain.Aggregates.Exercise;

using BodyPart = TrackMyMacros.Domain.Aggregates.Exercise.BodyPart;
namespace TrackMyMacros.Persistance.Repositories;

public class SeedExerciseData
{
    public static IReadOnlyList<Exercise> GetExercises()
    {
        var exercises= new List<Exercise>
        {
            Exercise.Flyes(),
            Exercise.BenchPress(),
            Exercise.Squat(),
            Exercise.Deadlift(),
            Exercise.InclineDumbbellPress(),
            Exercise.PullDown(),
            //add the remaining exercises
            Exercise.CableCrunch(),
            Exercise.ReverseNordics(),
            Exercise.DualCableRow(),
            Exercise.RDL(),
            Exercise.CalvesFourSecondEccentric(),
            Exercise.CalvesTwoSecondPause(),
            Exercise.LyingDumbellBicepCurl(),
            Exercise.LyingOverheadTricepsExtension(),
            Exercise.SingleArmCableLateralRaise(),
            
        };
        
        return exercises.AsReadOnly();
    }
    
    public static IReadOnlyList<BodyPart> GetBodyParts()
    {
        var bodyParts = new List<BodyPart>
        {
            BodyPart.Calves(),
            BodyPart.Back(),
            BodyPart.Biceps(),
            BodyPart.Triceps(),
            BodyPart.Chest(),
            BodyPart.Abs(),
            BodyPart.Shoulders(),
            BodyPart.Hamstrings(),
            BodyPart.Quads(),
            BodyPart.Glutes(),
            BodyPart.Neck(),
            BodyPart.Forearms(),
            BodyPart.Traps(),
            BodyPart.LowerBack(),
        };
        return bodyParts.AsReadOnly();
    }
    

}
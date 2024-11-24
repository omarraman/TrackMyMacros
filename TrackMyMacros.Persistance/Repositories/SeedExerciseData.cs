using TrackMyMacros.Application.Features;
using TrackMyMacros.Domain.Aggregates.Exercise;

namespace TrackMyMacros.Persistance.Repositories;

public class SeedExerciseData
{
    public static IReadOnlyList<Exercise> GetExercises()
    {
        return new List<Exercise>
        {
            new Exercise()
            {
                Id = Guid.NewGuid(),
                Name = "Incline Dumbell Press",
                Description = "Push-ups are a great bodyweight exercise for the upper body.",
                VideoUrl = "https://www.youtube.com/watch?v=Eh00_rniF8E",
                BodyPartId = new Guid("8D68C9E3-F8B3-4D17-9446-1E188A1A4744")
            },
            new Exercise()
            {
                Id = Guid.NewGuid(),
                Name = "Bench Press",
                Description = "Push-ups are a great bodyweight exercise for the upper body.",
                VideoUrl = "https://www.youtube.com/watch?v=Eh00_rniF8E",
                BodyPartId = new Guid("8D68C9E3-F8B3-4D17-9446-1E188A1A4744")
            },
            new Exercise()
            {
                Id = Guid.NewGuid(),
                Name = "Flyes",
                Description = "Push-ups are a great bodyweight exercise for the upper body.",
                VideoUrl = "https://www.youtube.com/watch?v=Eh00_rniF8E",
                BodyPartId = new Guid("8D68C9E3-F8B3-4D17-9446-1E188A1A4744")
            },
            new Exercise()
            {
                Id = new Guid("C6D5A37C-6F19-40D5-93AE-0BE9A6A9B8D3"),
                Name = "Lat Pulldown",
                Description = "A machine exercise that targets the latissimus dorsi muscles.",
                VideoUrl = "https://www.youtube.com/watch?v=CAwf7n6Luuc",
                BodyPartId = new Guid("6A10D667-3BAE-4473-905F-8EDF3D235522")
            },
            new()
            {
                Id = new Guid("2A7B2787-5E1F-4A5D-8D84-0ACA46D6052C"),
                Name = "Squats",
                Description = "An essential exercise for building leg strength.",
                VideoUrl = "https://www.youtube.com/watch?v=Dy28eq2PjcM",
                BodyPartId = new Guid("4045F98F-21B0-4C61-8FD0-DD02A21547C4")
            },
            new Exercise()
            {
                Id = new Guid("C7D8A457-41C5-4AA9-B47D-F33AA74D2772"),
                Name = "Rows",
                Description = "A great exercise to build a strong back.",
                VideoUrl = "https://www.youtube.com/watch?v=GZbfZ033f74",
                BodyPartId = new Guid("6A10D667-3BAE-4473-905F-8EDF3D235522")
            },
            new Exercise()
            {
                Id = new Guid("3C9D6D81-631F-4787-9135-3668F22CAD6D"),
                Name = "Reverse Nordics",
                Description = "An advanced exercise for building quad strength and mobility.",
                VideoUrl = "https://www.youtube.com/watch?v=hEZYIrEXA2M",
                BodyPartId = new Guid("4045F98F-21B0-4C61-8FD0-DD02A21547C4")
            },
            new Exercise()
            {
                Id = new Guid("4F517CBD-A107-4C9A-8B9E-647F5310C0BB"),
                Name = "Sissy Squat",
                Description = "Targets and isolates the quadriceps.",
                VideoUrl = "https://www.youtube.com/watch?v=3B-3Khbht5E",
                BodyPartId = new Guid("4045F98F-21B0-4C61-8FD0-DD02A21547C4")
            },
            new Exercise()
            {
                Id = new Guid("5AAD75E5-FEAA-45D0-A34B-C7F413C621FC"),
                Name = "Romanian Deadlift (RDL)",
                Description = "An essential exercise for the hamstrings and glutes.",
                VideoUrl = "https://www.youtube.com/watch?v=2SHsk9Azd4M",
                BodyPartId = new Guid("D1FCE414-03CB-4A93-A203-7A55A0A20D88")
            },
            new Exercise()
            {
                Id = new Guid("6BBE5654-2A23-4D19-B55A-D04024B18BE3"),
                Name = "Calf Raises",
                Description = "A great exercise to target the calves.",
                VideoUrl = "https://www.youtube.com/watch?v=-M4-G8p8fmc",
                BodyPartId = new Guid("B96F38FD-1105-474D-A578-6CB661D9B882")
            },
            new Exercise()
            {
                Id = new Guid("7C00631D-77E2-4108-9F39-A6D48735BB90"),
                Name = "Crunches",
                Description = "A simple but effective core exercise.",
                VideoUrl = "https://www.youtube.com/watch?v=Xyd_fa5zoEU",
                BodyPartId = new Guid("9B32D4D5-B7A2-4AA3-8862-EEF026938E49")
            },
        };

        //create Exercises for the following where name is in the list {squats, bench press, flyes, lat pulldown, rows, squats, reverse nordics, sissy squat, rdl, calf raises, crunches}. Give them all guid literals
    }

    public static IReadOnlyList<BodyPart> GetBodyParts()
    {
        var bodyParts = new List<BodyPart>
        {
            new BodyPart { Id = new Guid("B96F38FD-1105-474D-A578-6CB661D9B882"), Name = "Calves" },
            new BodyPart { Id = new Guid("A44E98FC-A6A1-4955-9A4F-0D68EF89C4BA"), Name = "Triceps" },
            new BodyPart { Id = new Guid("6A10D667-3BAE-4473-905F-8EDF3D235522"), Name = "Back" },
            new BodyPart { Id = new Guid("8D68C9E3-F8B3-4D17-9446-1E188A1A4744"), Name = "Chest" },
            new BodyPart { Id = new Guid("FF4FDFE9-9345-4152-85CF-58327A32AF22"), Name = "Shoulders" },
            new BodyPart { Id = new Guid("D1FCE414-03CB-4A93-A203-7A55A0A20D88"), Name = "Hamstrings" },
            new BodyPart { Id = new Guid("4045F98F-21B0-4C61-8FD0-DD02A21547C4"), Name = "Quads" },
            new BodyPart { Id = new Guid("5B73818B-2C0F-43A5-AA15-02DF756AB481"), Name = "Glutes" },
            new BodyPart { Id = new Guid("81D308C8-5CE7-44A5-B9C1-00C610E79B5C"), Name = "Neck" },
            new BodyPart { Id = new Guid("9B32D4D5-B7A2-4AA3-8862-EEF026938E49"), Name = "Abdominals" }
        };
            //add a new bodypart for abs
            

        return bodyParts.AsReadOnly();
    }
}
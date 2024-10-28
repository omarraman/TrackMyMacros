using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Application.Features;

public class ExerciseSet:Entity
{
    public Guid Id { get; set; }
    public int Reps { get; set; }
    public int Sets { get; set; }
    public double Weight { get; set; }
    public Exercise Exercise { get; set; }
    public Guid ExerciseId { get; set; }

}
using TrackMyMacros.Application.Features;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

public class MicroCycle:ValueObject<MicroCycle>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<ExerciseSet> ExerciseSets { get; set; }
    protected override bool EqualsCore(MicroCycle other)
    {
        throw new NotImplementedException();
    }

    protected override int GetHashCodeCore()
    {
        throw new NotImplementedException();
    }
}
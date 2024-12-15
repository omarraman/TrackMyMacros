using TrackMyMacros.Application.Features;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

public class MicroCycle : ValueObject<MicroCycle>
{
    //public Guid Id { get; set; }
    //public string Name { get; set; }
    public int WeekIndex { get; set; }
    public List<NanoCycle> NanoCycles { get; set; }

    protected override bool EqualsCore(MicroCycle other)
    {
        throw new NotImplementedException();
    }

    protected override int GetHashCodeCore()
    {
        int hashCode = WeekIndex;
        foreach (var nanoCycle in NanoCycles)
        {
            hashCode = HashCode.Combine(hashCode, nanoCycle);
        }

        return hashCode;
    }
}
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

public class MesoCycle:Entity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<MicroCycle> MicroCycles { get; set; }
}
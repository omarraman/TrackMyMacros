using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

public class BodyPart:Entity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
}
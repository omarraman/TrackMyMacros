using TrackMyMacros.Domain.Aggregates.Exercise;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Application.Features;

public class Exercise:Entity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string VideoUrl { get; set; }
    public BodyPart BodyPart { get; set; }
    public Guid BodyPartId { get; set; }
}

//a set can have an exercise, weight, reps and an index
//does it have an inherent identity or is it just a collection of values
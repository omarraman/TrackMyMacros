using System.Reflection.Metadata;
using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Application.Features;

public class BodyPart:Entity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
}
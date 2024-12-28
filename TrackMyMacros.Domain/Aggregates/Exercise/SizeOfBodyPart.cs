using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

public class SizeOfBodyPart:ValueObject<SizeOfBodyPart>
{
    public SizeOfBodyPart(double size)
    {
        Size = size;
    }

    public static SizeOfBodyPart One() => new(1);
    public static SizeOfBodyPart Two() => new(2);
    public static SizeOfBodyPart Three() => new(3);
    public static SizeOfBodyPart Four() => new(4);    
    
    
    public double Size { get; init; }

    protected override bool EqualsCore(SizeOfBodyPart other)
    {
        return Size == other.Size;
    }

    protected override int GetHashCodeCore()
    {
        return Size.GetHashCode();
    }
}
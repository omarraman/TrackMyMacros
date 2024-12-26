using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

public class BodyPartSize:ValueObject<BodyPartSize>
{
    public BodyPartSize(double size)
    {
        Size = size;
    }

    public static BodyPartSize One() => new(1);
    public static BodyPartSize Two() => new(2);
    public static BodyPartSize Three() => new(3);
    public static BodyPartSize Four() => new(4);    
    
    
    public double Size { get; init; }

    protected override bool EqualsCore(BodyPartSize other)
    {
        return Size == other.Size;
    }

    protected override int GetHashCodeCore()
    {
        return Size.GetHashCode();
    }
}
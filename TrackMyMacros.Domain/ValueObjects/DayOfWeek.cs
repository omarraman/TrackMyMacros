using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.Aggregates.Exercise;

public class DayOfWeek:ValueObject<DayOfWeek>
{
    private readonly int _dayOfWeek;
    public DayOfWeek(int dayOfWeek)
    {
        if (dayOfWeek < 1 || dayOfWeek > 7)
            throw new ArgumentOutOfRangeException(nameof(dayOfWeek), "Day of week must be between 1 and 7");

        _dayOfWeek = dayOfWeek;
    }

    public static DayOfWeek Monday() => new(1);
    public static DayOfWeek Tuesday() => new(2);
    public static DayOfWeek Wednesday() => new(3);
    public static DayOfWeek Thursday() => new(4);
    public static DayOfWeek Friday() => new(5);
    public static DayOfWeek Saturday() => new(6);
    public static DayOfWeek Sunday() => new(7);
    
    public int GetNumericEquivalent() => _dayOfWeek;

    protected override bool EqualsCore(DayOfWeek other)
    {
        if (ReferenceEquals(this, other)) return true;
        return _dayOfWeek == other.GetNumericEquivalent();
    }

    public override int GetHashCode()
    {
        return _dayOfWeek;
    }

    protected override int GetHashCodeCore()
    {
        throw new NotImplementedException();
    }
}
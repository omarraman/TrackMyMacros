using TrackMyMacros.Domain.Common;

namespace TrackMyMacros.Domain.ValueObjects;

public class MyDayOfWeekOld:ValueObject<MyDayOfWeekOld>
{
    private readonly int _dayOfWeek;
    public MyDayOfWeekOld(int dayOfWeek)
    {
        if (dayOfWeek < 1 || dayOfWeek > 7)
            throw new ArgumentOutOfRangeException(nameof(dayOfWeek), "Day of week must be between 1 and 7");

        _dayOfWeek = dayOfWeek;
    }

    public static MyDayOfWeekOld Monday() => new(1);
    public static MyDayOfWeekOld Tuesday() => new(2);
    public static MyDayOfWeekOld Wednesday() => new(3);
    public static MyDayOfWeekOld Thursday() => new(4);
    public static MyDayOfWeekOld Friday() => new(5);
    public static MyDayOfWeekOld Saturday() => new(6);
    public static MyDayOfWeekOld Sunday() => new(7);
    
    public int Value() => _dayOfWeek;

    protected override bool EqualsCore(MyDayOfWeekOld other)
    {
        if (ReferenceEquals(this, other)) return true;
        return _dayOfWeek == other.Value();
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
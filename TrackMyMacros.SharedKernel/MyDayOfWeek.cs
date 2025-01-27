using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Attributes;

namespace TrackMyMacros.SharedKernel;

[Keyless]
[PrimitiveWrapper(Type = "int")]
public class MyDayOfWeek:ValueObject<MyDayOfWeek>
{
    private readonly int _dayOfWeek;
    public MyDayOfWeek(int dayOfWeek)
    {
        if (dayOfWeek < 1 || dayOfWeek > 7)
            throw new ArgumentOutOfRangeException(nameof(dayOfWeek), "Day of week must be between 1 and 7");

        _dayOfWeek = dayOfWeek;
    }

    private MyDayOfWeek()
    {
        
    }

    public static MyDayOfWeek Monday() => new(1);
    public static MyDayOfWeek Tuesday() => new(2);
    public static MyDayOfWeek Wednesday() => new(3);
    public static MyDayOfWeek Thursday() => new(4);
    public static MyDayOfWeek Friday() => new(5);
    public static MyDayOfWeek Saturday() => new(6);
    public static MyDayOfWeek Sunday() => new(7);
    
    public int Value() => _dayOfWeek;
    
    public static MyDayOfWeek ConvertFromInt(int dayOfWeek)
    {
        if (dayOfWeek < 1 || dayOfWeek > 7)
            throw new ArgumentOutOfRangeException(nameof(dayOfWeek), "Day of week must be between 1 and 7");

        return new MyDayOfWeek(dayOfWeek);
    }

    protected override bool EqualsCore(MyDayOfWeek other)
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
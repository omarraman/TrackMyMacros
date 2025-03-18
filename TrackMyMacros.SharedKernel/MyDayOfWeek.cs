using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Attributes;

namespace TrackMyMacros.SharedKernel;

[JsonConverter(typeof(MyDayOfWeekConverter))]
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
    
    public string StringEquivalent()
    {
        return _dayOfWeek switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
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

public class MyDayOfWeekConverter : JsonConverter<MyDayOfWeek>
{
    public override MyDayOfWeek Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        int value = reader.GetInt32();
        return MyDayOfWeek.ConvertFromInt(value);
    }

    public override void Write(Utf8JsonWriter writer, MyDayOfWeek value, JsonSerializerOptions options)
    {
        writer.WriteNumberValue(value.Value());
    }
}
﻿namespace TrackMyMacros.Domain.Common;

public abstract class ValueObject<T>
    where T : ValueObject<T>
{
    public override bool Equals(object obj)
    {
        if (obj is not T valueObject)
            return false;

        return EqualsCore(valueObject);
    }


    protected abstract bool EqualsCore(T other);


    public override int GetHashCode()
    {
        return GetHashCodeCore();
    }


    protected abstract int GetHashCodeCore();


    public static bool operator ==(ValueObject<T>? a, ValueObject<T>? b)
    {
        if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            return true;

        if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            return false;

        return a.Equals(b);
    }


    public static bool operator !=(ValueObject<T> a, ValueObject<T> b)
    {
        return !(a == b);
    }
}


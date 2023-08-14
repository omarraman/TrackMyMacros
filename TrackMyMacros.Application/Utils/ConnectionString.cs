namespace TrackMyMacros.Application.Utils;

public sealed class ConnectionString
{
    public string Value { get; set; }

    public ConnectionString(string value)
    {
        Value=value;
    }
    
}
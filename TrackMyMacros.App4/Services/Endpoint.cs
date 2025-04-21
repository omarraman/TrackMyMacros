namespace TrackMyMacros.App4.Services;

public class Endpoint
{
    public string Value
    {
        get { return _endpoint; }
    }

    private string _endpoint;

    private Endpoint(string endpoint)
    {
        _endpoint = endpoint;
    }
    public static readonly Endpoint Mesocycle = new("Mesocycle");
    public static readonly Endpoint Exercise = new("Exercise");
}
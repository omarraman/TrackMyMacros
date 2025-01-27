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
    public static Endpoint Mesocycle = new("Mesocycle");
}
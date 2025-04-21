using System.Net;
using Flurl.Http.Configuration;

namespace TrackMyMacros.App4;

public class HttpClientFactoryForBlazor : DefaultHttpClientFactory
{
    public override HttpMessageHandler CreateMessageHandler()
    {
        var httpClientHandler = new HttpClientHandler();

        // flurl has its own mechanisms for managing cookies and redirects

        try 
        { 
            httpClientHandler.UseCookies = false; 
        }
        catch(PlatformNotSupportedException) { } // look out for WASM platforms (#543)

        if(httpClientHandler.SupportsRedirectConfiguration)
            httpClientHandler.AllowAutoRedirect = false;

        if(httpClientHandler.SupportsAutomaticDecompression)
        {
            // #266
            // deflate not working? see #474
            try
            {
                httpClientHandler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            }
            catch(PlatformNotSupportedException) { }
        }

        return httpClientHandler;
    }
}
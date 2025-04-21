namespace TrackMyMacros.Api;

public class RequestResponseLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public RequestResponseLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        // Log request body
        context.Request.EnableBuffering();
        var requestBody = await new StreamReader(context.Request.Body).ReadToEndAsync();
        context.Request.Body.Position = 0;
        Console.WriteLine($"Request Body: {requestBody}");

        // Proceed to the next middleware
        await _next(context);

        // Log response status code
        Console.WriteLine($"Response Status Code: {context.Response.StatusCode}");
    }
}
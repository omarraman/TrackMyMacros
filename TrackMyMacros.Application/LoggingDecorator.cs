using MediatR;
using Microsoft.Extensions.Logging;

namespace TrackMyMacros.Application;


public class LoggingDecorator<TRequest,TResponse> : IRequestHandler<TRequest,TResponse> where TRequest : RequestBase<TResponse>  
{
    private readonly IRequestHandler<TRequest, TResponse> _decoratee;
    private readonly ILogger _logger;

    public LoggingDecorator(IRequestHandler<TRequest,TResponse> decoratee,ILogger logger)
    {
        _logger = logger;
        _decoratee = decoratee;
    }
    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
    {
        try
        {
            return await _decoratee.Handle(request, cancellationToken);
        }
        catch (Exception e)
        {
            _logger.LogError(e,"Error in handler");
            throw;
        }

    }
}
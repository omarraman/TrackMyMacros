

using MediatR;

namespace TrackMyMacros.Application;

public abstract class RequestBase<TResponse> : IRequest<TResponse>
{

}

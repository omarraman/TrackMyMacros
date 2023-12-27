namespace TrackMyMacros.Infrastructure.Interfaces;

internal interface IErrorResult
{
    string Message { get; }
    IReadOnlyCollection<global::Error> Errors { get; }
}
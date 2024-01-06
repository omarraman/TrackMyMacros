using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Services;



public class NoDayAtDateErrorResult : ErrorResult<DayViewModel>
{
    public NoDayAtDateErrorResult(string message) : base(message)
    {
    }


}
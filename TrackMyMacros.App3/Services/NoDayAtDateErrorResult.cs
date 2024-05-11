using TrackMyMacros.App3.ViewModels;

namespace TrackMyMacros.App3.Services;



public class NoDayAtDateErrorResult : ErrorResult<DayViewModel>
{
    public NoDayAtDateErrorResult(string message) : base(message)
    {
    }


}
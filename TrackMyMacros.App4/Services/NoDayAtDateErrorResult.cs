using TrackMyMacros.App4.ViewModels;

namespace TrackMyMacros.App4.Services
{
    public class NoDayAtDateErrorResult : ErrorResult<DayViewModel>
    {
        public NoDayAtDateErrorResult(string message) : base(message)
        {
        }


    }
}
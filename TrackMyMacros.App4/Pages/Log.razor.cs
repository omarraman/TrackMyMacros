using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Services;

namespace TrackMyMacros.App4.Pages
{
    public partial class Log
    {
        [Inject]
        public ILogDataService LogDataService { get; set; }

    
        protected async override Task OnInitializedAsync()
    {
        Logs = await LogDataService.GetLogs();
    }

        public string Logs { get; set; }

    }
}
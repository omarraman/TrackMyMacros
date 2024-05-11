using Microsoft.AspNetCore.Components;
using TrackMyMacros.App3.Services;

namespace TrackMyMacros.App3.Components.Pages;

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
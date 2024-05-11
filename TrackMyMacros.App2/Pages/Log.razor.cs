using Microsoft.AspNetCore.Components;
using TrackMyMacros.App2.Interfaces;
using TrackMyMacros.App2.Services;
using TrackMyMacros.App2.ViewModels;

namespace TrackMyMacros.App2.Pages;

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
using Microsoft.AspNetCore.Components;
using TrackMyMacros.App4.Services;
using TrackMyMacros.App4.ViewModelsWeightReading;
using TrackMyMacros.Dtos.WeightReading;

namespace TrackMyMacros.App4.Pages;

public partial class WeightReadingChart
{
    [Inject] public IGenericDataService _dataService { get; set; }

    public bool ShowMarkers { get; set; }
    public bool ShowDataLabels { get; set; }
    public bool Smooth { get; set; }

    public DateTime From { get; set; } =   DateTime.Now.Date.AddMonths(-1);
    public DateTime To { get; set; } =   DateTime.Now.Date;
    
    private List<KeyValuePair<int, string>> ChartGranularity = new();
    
    public IReadOnlyList<GetWeightReadingViewModel> WeightReadings { get; set; }

    public int SelectedChartGranularity { get; set; }= 1;

    protected override async Task OnInitializedAsync()
    {
        ChartGranularity.Add(new KeyValuePair<int, string>(1, "Day"));
        ChartGranularity.Add(new KeyValuePair<int, string>(7, "Week"));
        ChartGranularity.Add(new KeyValuePair<int, string>(30, "Month"));
        await Refresh();
    }

    private async Task Refresh()
    {
        var temp = await _dataService.GetList<GetWeightReadingViewModel, GetWeightReadingDto>(GenericDataService
            .Endpoints.WeightReading);
        //group the weight readings by week and then get the average weight for each week
        temp= temp.Where(m=>m.Date>=From && m.Date<=To).ToList();

        temp = temp.GroupBy(i => i.Date.DayOfYear / SelectedChartGranularity).Select(g => new GetWeightReadingViewModel
        {
            Date = g.First().Date,
            Weight = Double.Round(g.Average(x => x.Weight), 2, MidpointRounding.AwayFromZero)
        }).ToList();

        WeightReadings = temp.OrderBy(m => m.Date).ToList();
    }


}
using TrackMyMacros.Dtos.WeightReading;

namespace TrackMyMacros.Application.Features.WeightReading.Queries.GetList;

public class GetWeightReadingListQuery : RequestBase<IReadOnlyList<GetWeightReadingDto>>
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public double Weight { get; set; }
}
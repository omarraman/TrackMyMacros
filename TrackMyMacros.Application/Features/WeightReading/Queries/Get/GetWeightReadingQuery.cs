using TrackMyMacros.Dtos.WeightReading;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.SharedKernel;

namespace TrackMyMacros.Application.Features.WeightReading.Queries.Get
{
    public class GetWeightReadingQuery : RequestBase<Maybe<GetWeightReadingDto>>
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double Weight { get; set; }
    }
    
}
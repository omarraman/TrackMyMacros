using AutoMapper;
using TrackMyMacros.Dtos.WeightReading;
using TrackMyMacros.Domain.Aggregates.WeightReading;

namespace TrackMyMacros.Application.Profiles.WeightReading
{
    public class GetWeightReadingMappingProfile : Profile
    {
        public GetWeightReadingMappingProfile()
        {
            CreateMap<Domain.Aggregates.WeightReading.WeightReading, GetWeightReadingDto>();
        }
    }
}
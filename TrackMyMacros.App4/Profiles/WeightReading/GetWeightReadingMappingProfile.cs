using AutoMapper;
using TrackMyMacros.Dtos.WeightReading;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.App4.ViewModelsWeightReading;

namespace TrackMyMacros.App4.Profiles.WeightReading
{
    public class GetWeightReadingMappingProfile : Profile
    {
        public GetWeightReadingMappingProfile()
        {
            CreateMap<GetWeightReadingDto, GetWeightReadingViewModel>();
        }
    }
}
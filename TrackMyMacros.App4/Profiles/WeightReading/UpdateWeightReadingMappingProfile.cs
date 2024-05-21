using AutoMapper;
using TrackMyMacros.Dtos.WeightReading;
using TrackMyMacros.App4.ViewModels;

namespace TrackMyMacros.App4.Profiles.WeightReading
{
    public class UpdateWeightReadingMappingProfile : Profile
    {
        public UpdateWeightReadingMappingProfile()
        {
            CreateMap<WeightReadingViewModel, UpdateWeightReadingDto>();
        }
    }
}
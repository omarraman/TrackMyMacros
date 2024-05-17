using AutoMapper;
using TrackMyMacros.App4.ViewModels;
using TrackMyMacros.Dtos.WeightReading;

namespace TrackMyMacros.App4.Profiles.WeightReading;

public class CreateWeightReadingMappingProfile : Profile
{
    public CreateWeightReadingMappingProfile()
    {
        CreateMap<WeightReadingViewModel,CreateWeightReadingDto>();
    }
}

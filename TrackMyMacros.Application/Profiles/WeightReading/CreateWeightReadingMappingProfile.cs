using AutoMapper;
using TrackMyMacros.Dtos.WeightReading;
using TrackMyMacros.Domain.Aggregates.WeightReading;
using TrackMyMacros.Application.Features.WeightReading.Commands.Create;

namespace TrackMyMacros.Application.Profiles.WeightReading
{
    public class CreateWeightReadingMappingProfile : Profile
    {
        public CreateWeightReadingMappingProfile()
        {
            CreateMap<CreateWeightReadingDto, CreateWeightReadingCommand>();
            CreateMap<CreateWeightReadingCommand, Domain.Aggregates.WeightReading.WeightReading>();
        }
    }
}
using AutoMapper;
using TrackMyMacros.Dtos.WeightReading;
using TrackMyMacros.Domain.Aggregates.WeightReading;
using TrackMyMacros.Application.Features.WeightReading.Commands.Update;

namespace TrackMyMacros.Application.Profiles.WeightReading
{
    public class UpdateWeightReadingMappingProfile : Profile
    {
        public UpdateWeightReadingMappingProfile()
        {
            CreateMap<UpdateWeightReadingDto, UpdateWeightReadingCommand>();
            CreateMap<UpdateWeightReadingCommand, Domain.Aggregates.WeightReading.WeightReading>();
        }
    }
}
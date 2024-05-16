using AutoMapper;
using MediatR;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.Application;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Dtos.WeightReading;

namespace TrackMyMacros.Application.Features.WeightReading.Queries.Get
{
    public class GetWeightReadingQueryHandler : IRequestHandler<GetWeightReadingQuery, Maybe<GetWeightReadingDto>>
    {
        private IMapper _mapper;
        private IWeightReadingRepository _weightReadingRepository;
        public GetWeightReadingQueryHandler(IMapper mapper, IWeightReadingRepository weightReadingRepository)
        {
            _weightReadingRepository = weightReadingRepository;
            _mapper = mapper;
        }

        public async Task<Maybe<GetWeightReadingDto>> Handle(GetWeightReadingQuery request, CancellationToken cancellationToken)
        {
            var results = await _weightReadingRepository.GetByIdAsync(request.Id);
            var mapped = results.HasValue ? _mapper.Map<GetWeightReadingDto>(results.Value) : Maybe<GetWeightReadingDto>.None;
            return mapped;
        }
    }
}
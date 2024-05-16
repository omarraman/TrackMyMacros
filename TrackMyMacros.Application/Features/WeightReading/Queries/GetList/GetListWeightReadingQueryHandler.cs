using AutoMapper;
using MediatR;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.Application;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Application.Features.WeightReading.Queries.Get;
using TrackMyMacros.Dtos.WeightReading;

namespace TrackMyMacros.Application.Features.WeightReading.Queries.GetList
{
    public class GetListWeightReadingQueryHandler : IRequestHandler<GetWeightReadingListQuery, IReadOnlyList<GetWeightReadingDto>>
    {
        private IMapper _mapper;
        private IWeightReadingRepository _weightReadingRepository;
        public GetListWeightReadingQueryHandler(IMapper mapper, IWeightReadingRepository weightReadingRepository)
        {
            _weightReadingRepository = weightReadingRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<GetWeightReadingDto>> Handle(GetWeightReadingListQuery request, CancellationToken cancellationToken)
        {
            var results = await _weightReadingRepository.ListAllAsync();
            var mapped = _mapper.Map<IReadOnlyList<GetWeightReadingDto>>(results);
            return mapped;
        }

    }
}
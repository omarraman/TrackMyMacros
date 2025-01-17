using AutoMapper;
using MediatR;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.Application;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Dtos.Mesocycle;

namespace TrackMyMacros.Application.Features.Mesocycle.Queries.Get
{
    public class GetMesocycleQueryHandler : IRequestHandler<GetMesocycleQuery, Maybe<GetMesocycleDto>>
    {
        private IMapper _mapper;
        private IMesocycleRepository _mesocycleRepository;
        public GetMesocycleQueryHandler(IMapper mapper, IMesocycleRepository mesocycleRepository)
        {
            _mesocycleRepository = mesocycleRepository;
            _mapper = mapper;
        }

        public async Task<Maybe<GetMesocycleDto>> Handle(GetMesocycleQuery request, CancellationToken cancellationToken)
        {
            var results = await _mesocycleRepository.GetByIdAsync(request.Id);
            var mapped = results.HasValue ? _mapper.Map<GetMesocycleDto>(results.Value) : Maybe<GetMesocycleDto>.None;
            return mapped;
        }
    }
}
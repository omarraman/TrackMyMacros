using AutoMapper;
using MediatR;
using TrackMyMacros.Infrastructure;
using TrackMyMacros.Application;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Dtos.Mesocycle;

namespace TrackMyMacros.Application.Features.Mesocycle.Queries.GetList
{
    public class GetListMesocycleQueryHandler : IRequestHandler<GetMesocycleListQuery, IReadOnlyList<GetMesocycleDto>>
    {
        private IMapper _mapper;
        private IMesocycleRepository _mesocycleRepository;
        public GetListMesocycleQueryHandler(IMapper mapper, IMesocycleRepository mesocycleRepository)
        {
            _mesocycleRepository = mesocycleRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<GetMesocycleDto>> Handle(GetMesocycleListQuery request, CancellationToken cancellationToken)
        {
            var results = await _mesocycleRepository.ListAllAsync();
            var mapped = _mapper.Map<IReadOnlyList<GetMesocycleDto>>(results);
            return mapped;
        }
    }
}
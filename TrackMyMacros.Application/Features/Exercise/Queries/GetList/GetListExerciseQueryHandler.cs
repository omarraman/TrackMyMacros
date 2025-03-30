using AutoMapper;
using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Dtos.Exercise;

namespace TrackMyMacros.Application.Features.Exercise.Queries.GetList{
    public class GetListExerciseQueryHandler : IRequestHandler<GetExerciseListQuery, IReadOnlyList<GetExerciseDto>>
    {
        private IMapper _mapper;
        private IExerciseRepository _exerciseRepository;
        public GetListExerciseQueryHandler(IMapper mapper, IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<GetExerciseDto>> Handle(GetExerciseListQuery request, CancellationToken cancellationToken)
        {
            var results = await _exerciseRepository.ListAllAsync();
            var mapped = _mapper.Map<IReadOnlyList<GetExerciseDto>>(results);
            return mapped;
        }
    }
}
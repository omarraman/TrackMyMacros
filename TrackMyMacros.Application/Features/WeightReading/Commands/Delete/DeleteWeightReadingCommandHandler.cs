using AutoMapper;
using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.WeightReading.Commands.Delete
{
    public class DeleteWeightReadingCommandHandler : IRequestHandler<DeleteWeightReadingCommand, Result>
    {
        private IMapper _mapper;
        private IWeightReadingRepository _weightReadingRepository;
        public DeleteWeightReadingCommandHandler(IMapper mapper, IWeightReadingRepository weightReadingRepository)
        {
            _weightReadingRepository = weightReadingRepository;
            _mapper = mapper;
        }

        public async Task<Result> Handle(DeleteWeightReadingCommand request, CancellationToken cancellationToken)
        {
            await _weightReadingRepository.DeleteAsync(request.Id);
            return new SuccessResult();
        }
    }
}
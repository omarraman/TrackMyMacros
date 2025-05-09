using AutoMapper;
using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.Mesocycle.Commands.Delete
{
    public class DeleteMesocycleCommandHandler : IRequestHandler<DeleteMesocycleCommand, Result>
    {
        private IMapper _mapper;
        private IMesocycleRepository _mesocycleRepository;
        public DeleteMesocycleCommandHandler(IMapper mapper, IMesocycleRepository mesocycleRepository)
        {
            _mesocycleRepository = mesocycleRepository;
            _mapper = mapper;
        }

        public async Task<Result> Handle(DeleteMesocycleCommand request, CancellationToken cancellationToken)
        {
            await _mesocycleRepository.DeleteAsync(request.Id);
            return new SuccessResult();
        }
    }
}
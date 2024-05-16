using AutoMapper;
using MediatR;
using TrackMyMacros.Application;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Common;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.WeightReading.Commands.Create
{
    public class CreateWeightReadingCommandHandler : IRequestHandler<CreateWeightReadingCommand, Result<Guid>>
    {
        private IMapper _mapper;
        private IWeightReadingRepository _weightReadingRepository;
        public CreateWeightReadingCommandHandler(IMapper mapper, IWeightReadingRepository weightReadingRepository)
        {
            _weightReadingRepository = weightReadingRepository;
            _mapper = mapper;
        }

        public async Task<Result<Guid>> Handle(CreateWeightReadingCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateWeightReadingCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
                return new ValidationErrorResult<Guid>(validationResult);
            var entity = _mapper.Map<Domain.Aggregates.WeightReading.WeightReading>(request);
            entity = await _weightReadingRepository.AddAsync(entity);
            return new SuccessResult<Guid>(entity.Id);
        }
    }
}
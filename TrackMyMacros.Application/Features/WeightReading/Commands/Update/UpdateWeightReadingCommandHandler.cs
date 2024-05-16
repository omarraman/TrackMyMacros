using AutoMapper;
using MediatR;
using TrackMyMacros.Application;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Common;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.WeightReading.Commands.Update
{
    public class UpdateWeightReadingCommandHandler : IRequestHandler<UpdateWeightReadingCommand, Result>
    {
        private IMapper _mapper;
        private IWeightReadingRepository _weightReadingRepository;
        public UpdateWeightReadingCommandHandler(IMapper mapper, IWeightReadingRepository weightReadingRepository)
        {
            _weightReadingRepository = weightReadingRepository;
            _mapper = mapper;
        }

        public async Task<Result> Handle(UpdateWeightReadingCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateWeightReadingCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
                return new ValidationErrorResult(validationResult);
            var weightReading = _mapper.Map<Domain.Aggregates.WeightReading.WeightReading>(request);
            await _weightReadingRepository.UpdateAsync(weightReading);
            return new SuccessResult();
        }
    }
}
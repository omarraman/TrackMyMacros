using AutoMapper;
using MediatR;
using TrackMyMacros.Application;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Common;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.Mesocycle.Commands.Update
{
    public class UpdateMesocycleCommandHandler : IRequestHandler<UpdateMesocycleCommand, Result>
    {
        private IMapper _mapper;
        private IMesocycleRepository _mesocycleRepository;
        private IExerciseRepository _exerciseRepository;

        public UpdateMesocycleCommandHandler(IMapper mapper, IMesocycleRepository mesocycleRepository,
            IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
            _mesocycleRepository = mesocycleRepository;
            _mapper = mapper;
        }

        public async Task<Result> Handle(UpdateMesocycleCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateMesocycleCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
                return new ValidationErrorResult(validationResult);
            var mesocycle = _mapper.Map<Domain.Aggregates.Mesocycle.Mesocycle>(request);

            var exercises = await _exerciseRepository.ListAllAsync();
            if (request.CurrentWorkoutComplete) mesocycle.AdvanceMesocycleToNextWorkout(exercises);
            
            await _mesocycleRepository.UpdateAsync(mesocycle);
            return new SuccessResult();
        }
    }
}
using AutoMapper;
using FluentValidation.Results;
using MediatR;
using TrackMyMacros.Application;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Common;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Application.Features.MesoCycle.Commands.Create;

namespace TrackMyMacros.Application.Features.Mesocycle.Commands.Create
{
    public class CreateMesocycleCommandHandler : IRequestHandler<CreateMesocycleCommand, Result<Guid>>
    {
        private IMapper _mapper;
        private IMesocycleRepository _mesocycleRepository;
        public CreateMesocycleCommandHandler(IMapper mapper, IMesocycleRepository mesocycleRepository)
        {
            _mesocycleRepository = mesocycleRepository;
            _mapper = mapper;
        }

        public async Task<Result<Guid>> Handle(CreateMesocycleCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateMesocycleCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
                return new ValidationErrorResult<Guid>(validationResult);
            var entity = _mapper.Map<Domain.Aggregates.Mesocycle.Mesocycle>(request);
            var entityErrors = entity.IsValid();
            
            if (!string.IsNullOrEmpty(entityErrors))
                return new ErrorResult<Guid>(entityErrors);
            entity = await _mesocycleRepository.AddAsync(entity);
            return new SuccessResult<Guid>(entity.Id);
        }
    }
}
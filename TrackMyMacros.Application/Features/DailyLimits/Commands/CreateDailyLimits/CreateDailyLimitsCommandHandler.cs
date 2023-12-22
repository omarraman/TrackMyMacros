using AutoMapper;
using CSharpFunctionalExtensions;
using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.DailyLimits.Commands.CreateDailyLimits;

public class CreateDailyLimitsCommandHandler:IRequestHandler<CreateDailyLimitsCommand,Result<Guid>>
{
    private IMapper _mapper;
    private IDailyLimitsRepository _dailyLimitsRepository;

    public CreateDailyLimitsCommandHandler(IMapper mapper,IDailyLimitsRepository dailyLimitsRepository)
    {
        _dailyLimitsRepository = dailyLimitsRepository;
        _mapper = mapper;
    }
    

    public async Task<Result<Guid>> Handle(CreateDailyLimitsCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateDailyLimitsCommandValidator();
        var validationResult = await validator.ValidateAsync(request);
        
        if (validationResult.Errors.Count > 0)
            return  Result.Failure<Guid>(validationResult.ToString(","));

        var dailyLimits = _mapper.Map<Domain.Aggregates.DailyLimit.DailyLimits>(request);

        dailyLimits = await _dailyLimitsRepository.AddAsync(dailyLimits);

        return dailyLimits.Id;

    }
}
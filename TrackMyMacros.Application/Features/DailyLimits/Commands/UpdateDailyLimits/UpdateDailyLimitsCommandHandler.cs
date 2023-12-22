using AutoMapper;
using CSharpFunctionalExtensions;
using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.DailyLimits.Commands.UpdateDailyLimits;

public class UpdateDailyLimitsCommandHandler:IRequestHandler<UpdateDailyLimitsCommand,Result>
{
    private IMapper _mapper;
    private IDailyLimitsRepository _dailyLimitsRepository;

    public UpdateDailyLimitsCommandHandler(IMapper mapper,IDailyLimitsRepository dailyLimitsRepository)
    {
        _dailyLimitsRepository = dailyLimitsRepository;
        _mapper = mapper;
    }
    

    public async Task<Result> Handle(UpdateDailyLimitsCommand request, CancellationToken cancellationToken)
    {
        var validator = new UpdateDailyLimitsCommandValidator();
        var validationResult = await validator.ValidateAsync(request);
        
        if (validationResult.Errors.Count > 0)
            return  Result.Failure<Guid>(validationResult.ToString(","));

        var dailyLimits = _mapper.Map<Domain.Aggregates.DailyLimit.DailyLimits>(request);

        await _dailyLimitsRepository.UpdateAsync(dailyLimits);

        return Result.Success();

    }
}
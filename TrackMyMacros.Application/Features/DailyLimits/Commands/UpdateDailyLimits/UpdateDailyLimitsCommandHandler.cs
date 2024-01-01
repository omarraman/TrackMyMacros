using AutoMapper;

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
        // var validator = new UpdateDailyLimitsCommandValidator();
        // var validationResult = await validator.ValidateAsync(request);
        //
        // if (validationResult.Errors.Count > 0)
        //     throw new Exception(validationResult.ToString(","));
        //
        // var dailyLimits = _mapper.Map<Domain.Aggregates.DailyLimit.DailyLimits>(request);

        Domain.Aggregates.DailyLimit.DailyLimits dailyLimits;
        try
        {
            dailyLimits = new Domain.Aggregates.DailyLimit.DailyLimits(request.Calories, request.Protein,
                request.Fat, request.Carbohydrate);
        }
        catch (ArgumentException e)
        {
            return new UpdateDailyLimitsInvalidArgumentsResult(e.Message);
        }
        await _dailyLimitsRepository.UpdateAsync(dailyLimits);

        return new SuccessResult();

    }
}
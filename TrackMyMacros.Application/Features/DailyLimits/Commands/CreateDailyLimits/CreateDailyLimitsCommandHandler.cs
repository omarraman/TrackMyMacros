using AutoMapper;
using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.DailyLimits.Commands.CreateDailyLimits;

public class CreateDailyLimitsCommandHandler : IRequestHandler<CreateDailyLimitsCommand, Result<Guid>>
{
    private IMapper _mapper;
    private IDailyLimitsRepository _dailyLimitsRepository;

    public CreateDailyLimitsCommandHandler(IMapper mapper, IDailyLimitsRepository dailyLimitsRepository)
    {
        _dailyLimitsRepository = dailyLimitsRepository;
        _mapper = mapper;
    }


    public async Task<Result<Guid>> Handle(CreateDailyLimitsCommand request, CancellationToken cancellationToken)
    {
        // var dailyLimits = _mapper.Map<Domain.Aggregates.DailyLimit.DailyLimits>(request);

        Domain.Aggregates.DailyLimit.DailyLimits dailyLimits;
        try
        {
            dailyLimits = new Domain.Aggregates.DailyLimit.DailyLimits(request.Calories, request.Protein,
                request.Fat, request.Carbohydrate);
        }
        catch (ArgumentException e)
        {
            return new CreateDailyLimitsInvalidArgumentsResult(e.Message);
        }

        dailyLimits = await _dailyLimitsRepository.AddAsync(dailyLimits);

        return new SuccessResult<Guid>(dailyLimits.Id);
    }
}
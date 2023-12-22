using AutoMapper;
using CSharpFunctionalExtensions;
using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Application.Features.Food.Commands.CreateFood;

namespace TrackMyMacros.Application.Features.Food.Commands.UpdateFood;

public class UpdateFoodCommandHandler:IRequestHandler<UpdateFoodCommand,Result>
{
    private IMapper _mapper;
    private IFoodRepository _foodRepository;

    public UpdateFoodCommandHandler(IMapper mapper,IFoodRepository foodRepository)
    {
        _foodRepository = foodRepository;
        _mapper = mapper;
    }
    

    public async Task<Result> Handle(UpdateFoodCommand request, CancellationToken cancellationToken)
    {
        var validator = new UpdateFoodCommandValidator();
        var validationResult = await validator.ValidateAsync(request);
        
        if (validationResult.Errors.Count > 0)
            return  Result.Failure<int>(validationResult.ToString(","));

        var food = _mapper.Map<Domain.Aggregates.Food>(request);

        var result = await _foodRepository.UpdateAsync(food);

        return result;

    }
}
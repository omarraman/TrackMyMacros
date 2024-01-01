using AutoMapper;

using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.Food.Commands.CreateFood;

public class CreateFoodCommandHandler:IRequestHandler<CreateFoodCommand,Result<int>>
{
    private IMapper _mapper;
    private IFoodRepository _foodRepository;

    public CreateFoodCommandHandler(IMapper mapper,IFoodRepository foodRepository)
    {
        _foodRepository = foodRepository;
        _mapper = mapper;
    }
    

    public async Task<Result<int>> Handle(CreateFoodCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateFoodCommandValidator();
        var validationResult = await validator.ValidateAsync(request);
        
        if (validationResult.Errors.Count > 0)
            throw new Exception(validationResult.ToString(","));

        var food = _mapper.Map<Domain.Aggregates.Food>(request);

        food = await _foodRepository.AddAsync(food);

        return new SuccessResult<int>(food.Id);

    }
}
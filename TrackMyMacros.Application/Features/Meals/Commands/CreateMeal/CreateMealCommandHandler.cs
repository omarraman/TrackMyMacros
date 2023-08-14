using AutoMapper;
using CSharpFunctionalExtensions;
using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Domain.Aggregates.Day;

namespace TrackMyMacros.Application.Features.Meals.Commands.CreateMeal;

public class CreateMealCommandHandler:IRequestHandler<CreateMealCommand,Result<int>>
{
    private IMapper _mapper;
    private IMealRepository _MealRepository;

    public CreateMealCommandHandler(IMapper mapper,IMealRepository MealRepository)
    {
        _MealRepository = MealRepository;
        _mapper = mapper;
    }

    public async Task<Result<int>> Handle(CreateMealCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateMealCommandValidator();
        var validationResult = await validator.ValidateAsync(request);
        
        if (validationResult.Errors.Count > 0)
            return  Result.Failure<int>(validationResult.ToString(","));

        var Meal = _mapper.Map<Meal>(request);

        Meal = await _MealRepository.AddAsync(Meal);

        return 1;

    }
}
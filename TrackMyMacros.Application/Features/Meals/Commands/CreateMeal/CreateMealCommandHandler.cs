﻿using AutoMapper;

using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Domain.Aggregates.Day;
using TrackMyMacros.Domain.ValueObjects;

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
            throw new Exception(validationResult.ToString(","));

        var Meal = _mapper.Map<Meal>(request);

        Meal = await _MealRepository.AddAsync(Meal);

        //todo
        return new SuccessResult<int>(1);

    }
}
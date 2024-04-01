using AutoMapper;
using MediatR;
using TrackMyMacros.Application.Common;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.FoodCombo.Commands.Create;

public class CreateFoodComboCommandHandler:IRequestHandler<CreateFoodComboCommand,Result<Guid>>
{
    private IMapper _mapper;
    private IFoodComboRepository _foodComboRepository;

    public CreateFoodComboCommandHandler(IMapper mapper,IFoodComboRepository foodComboRepository)
    {
        _foodComboRepository = foodComboRepository;
        _mapper = mapper;
    }
    

    public async Task<Result<Guid>> Handle(CreateFoodComboCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateFoodComboCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
            return new ValidationErrorResult<Guid>(validationResult);
        
        var food = _mapper.Map<Domain.Aggregates.FoodCombo.FoodCombo>(request);
        
        food = await _foodComboRepository.AddAsync(food);
        
        return new SuccessResult<Guid>(food.Id);
    }
}
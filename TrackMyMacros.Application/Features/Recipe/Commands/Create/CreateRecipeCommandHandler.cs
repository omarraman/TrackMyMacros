using AutoMapper;
using MediatR;
using TrackMyMacros.Application;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Common;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Domain;
using TrackMyMacros.Domain.ValueObjects;

namespace TrackMyMacros.Application.Features.Recipe.Commands.Create
{
    public class CreateRecipeCommandHandler : IRequestHandler<CreateRecipeCommand, Result<Guid>>
    {
        private IMapper _mapper;
        private IRecipeRepository _recipeRepository;
        private IFoodRepository _foodRepository;

        public CreateRecipeCommandHandler(IMapper mapper, IRecipeRepository recipeRepository,
            IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
            _recipeRepository = recipeRepository;
            _mapper = mapper;
        }

        public async Task<Result<Guid>> Handle(CreateRecipeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateRecipeCommandValidator();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Count > 0)
                return new ValidationErrorResult<Guid>(validationResult);
            var recipe = _mapper.Map<Domain.Aggregates.Recipe.Recipe>(request);
            var recipeGuid = Guid.NewGuid();
            var foodGuid = Guid.NewGuid();
            recipe.Id = recipeGuid;
            recipe.FoodId = foodGuid;
            var food = new Domain.Aggregates.Food
            {
                Guid = foodGuid,
                Name = recipe.Name + "(R)",
                CarbohydrateAmount = new CarbohydrateAmount(recipe.CarbohydratePer100G),
                FatAmount = new FatAmount(recipe.FatPer100G),
                ProteinAmount = new ProteinAmount(recipe.ProteinPer100G),
                Quantity = 100,
                RecipeId = recipeGuid,
                UomId = 1
            };
            await _recipeRepository.AddAsync(recipe, food);
            return new SuccessResult<Guid>(recipe.Id);
        }
    } 
}
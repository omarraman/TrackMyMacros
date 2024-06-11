using AutoMapper;
using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.Recipe.Commands.Delete
{
    public class DeleteRecipeCommandHandler : IRequestHandler<DeleteRecipeCommand, Result>
    {
        private IMapper _mapper;
        private IRecipeRepository _recipeRepository;
        public DeleteRecipeCommandHandler(IMapper mapper, IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
            _mapper = mapper;
        }

        public async Task<Result> Handle(DeleteRecipeCommand request, CancellationToken cancellationToken)
        {
            await _recipeRepository.DeleteAsync(request.Id);
            return new SuccessResult();
        }
    }
}
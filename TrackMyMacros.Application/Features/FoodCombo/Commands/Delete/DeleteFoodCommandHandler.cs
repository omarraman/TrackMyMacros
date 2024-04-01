using AutoMapper;
using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;

namespace TrackMyMacros.Application.Features.FoodCombo.Commands.Delete;

public class DeleteFoodComboCommandHandler:IRequestHandler<DeleteFoodComboCommand,Result>
{
    private IMapper _mapper;
    private IFoodComboRepository _foodComboRepository;

    public DeleteFoodComboCommandHandler(IMapper mapper,IFoodComboRepository foodComboRepository)
    {
        _foodComboRepository = foodComboRepository;
        _mapper = mapper;
    }
    

    public async Task<Result> Handle(DeleteFoodComboCommand request, CancellationToken cancellationToken)
    {
        await _foodComboRepository.DeleteAsync(request.Id);
        return new SuccessResult();
    }


}
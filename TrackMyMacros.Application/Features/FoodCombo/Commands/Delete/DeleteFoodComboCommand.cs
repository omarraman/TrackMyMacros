
using MediatR;

namespace TrackMyMacros.Application.Features.FoodCombo.Commands.Delete;

public class DeleteFoodComboCommand:RequestBase<Result>
{
    public Guid Id { get; set; }
    
    

}


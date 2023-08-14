using CSharpFunctionalExtensions;
using MediatR;

namespace TrackMyMacros.Application.Features.Food.Commands.CreateFood;

public class CreateFoodCommand:IRequest<Result<int>>
{
    public string Name { get; set; }
    public double Carbohydrate { get; set; }
    public double Protein { get; set; }
    public double Fat { get; set; }

    public double Quantity { get; set; }
    public int UomId { get; set; }

}
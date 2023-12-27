using CSharpFunctionalExtensions;
using MediatR;
using TrackMyMacros.Domain;

namespace TrackMyMacros.Application.Features.Meals.Commands.CreateMeal;

public class CreateMealCommand:RequestBase<Result<int>>
{
    public string Name { get; set; }
    public Domain.Uom Uom { get; set; }
}
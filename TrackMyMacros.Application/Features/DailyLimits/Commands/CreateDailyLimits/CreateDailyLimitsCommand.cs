using CSharpFunctionalExtensions;
using MediatR;

namespace TrackMyMacros.Application.Features.DailyLimits.Commands.CreateDailyLimits;

public class CreateDailyLimitsCommand:RequestBase<Result<Guid>>
{
    public int Carbohydrate { get; set; }
    public int Protein { get; set; }
    public int Fat { get; set; }
    public int Calories { get; set; }

}
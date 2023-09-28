using AutoMapper;
using CSharpFunctionalExtensions;
using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Application.Features.Food.Commands.CreateFood;

namespace TrackMyMacros.Application.Features.Day.Commands;

public class UpdateDayCommandHandler : IRequestHandler<UpdateDayCommand, Result>
{
    private IMapper _mapper;
    private IDayRepository _dayRepository;

    public UpdateDayCommandHandler(IMapper mapper, IDayRepository dayRepository)
    {
        _dayRepository = dayRepository;
        _mapper = mapper;
    }


    public async Task<Result> Handle(UpdateDayCommand command, CancellationToken cancellationToken)
    {
        var validator = new UpdateDayCommandValidator();
        var validationResult = await validator.ValidateAsync(command);

        if (validationResult.Errors.Count > 0)
            return Result.Failure(validationResult.ToString(","));

        var day = _mapper.Map<Domain.Aggregates.Day.Day>(command);

        await _dayRepository.UpdateAsync(day);

        return Result.Success();
    }
}
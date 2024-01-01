using AutoMapper;

using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;

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
            throw new Exception(validationResult.ToString(","));

        var day = _mapper.Map<Domain.Aggregates.Day.Day>(command);

        await _dayRepository.UpdateAsync(day);

        return new SuccessResult();
    }
}
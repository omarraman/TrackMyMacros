using AutoMapper;

using MediatR;
using TrackMyMacros.Application.Contracts.Persistence;
using TrackMyMacros.Dtos;
using TrackMyMacros.Infrastructure;

namespace TrackMyMacros.Application.Features.Day.Queries;

public class GetDayQuery:RequestBase<Maybe<GetDayDto>>
{
    public DateOnly Date { get; set; }
}

public class GetDayQueryHandler : IRequestHandler<GetDayQuery, Maybe<GetDayDto>>
{
    private readonly IDayRepository _repository;
    private IMapper _mapper;

    public async Task<Maybe<GetDayDto>> Handle(GetDayQuery request, CancellationToken cancellationToken)
    {
        var results= await _repository.GetByDateAsync(request.Date);
        var mapped= results.HasValue? _mapper.Map<GetDayDto>(results.Value):Maybe<GetDayDto>.None;
        return mapped;
    }

    public GetDayQueryHandler(IDayRepository repository,IMapper mapper)
    {
        _mapper = mapper;
        _repository = repository;
    }
}
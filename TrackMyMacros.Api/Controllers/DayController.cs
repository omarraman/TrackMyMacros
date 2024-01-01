using AutoMapper;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrackMyMacros.Application.Features.Day.Commands;
using TrackMyMacros.Application.Features.Day.Queries;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DayController : ControllerBase
{
    private IMediator _mediator;
    private readonly IMapper _mapper;

    public DayController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet(Name = "GetDay")]
    [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
    public async Task<ActionResult<GetDayDto>> Get([FromQuery] DateTime date)
    {
        var dayOrNone = await _mediator.Send(new GetDayQuery { Date = DateOnly.FromDateTime(date) });
        if (dayOrNone.HasNoValue)
        {
            return NotFound();
        }

        return dayOrNone.Value;
    }
    
    [HttpPost(Name = "Update")]
    [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
    [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Update([FromBody] UpdateDayDto updateDayDto)
    {
        var command = _mapper.Map<UpdateDayCommand>(updateDayDto);
        await _mediator.Send(command);

        return NoContent();

    }
}
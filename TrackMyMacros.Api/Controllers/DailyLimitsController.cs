using AutoMapper;
using CSharpFunctionalExtensions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrackMyMacros.Application.Features.DailyLimits.Commands.CreateDailyLimits;
using TrackMyMacros.Application.Features.DailyLimits.Commands.UpdateDailyLimits;
using TrackMyMacros.Application.Features.DailyLimits.Queries.GetDailyLimits;
using TrackMyMacros.Domain.Aggregates.DailyLimit;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DailyLimitsController:ControllerBase
{
    private IMediator _mediator;
    private readonly IMapper _mapper;

    public DailyLimitsController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
    
    [HttpGet]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    public async Task<ActionResult<GetDailyLimitsDto>> Get()
    {
        var dailyLimits= await _mediator.Send(new GetDailyLimitsQuery());
        if (dailyLimits.HasNoValue)
            return NotFound();

        return dailyLimits.Value;
    }
    
    
    [HttpPost(Name = "CreateDailyLimits")]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    public async Task<Result<Guid>> Post(CreateDailyLimitsDto dto)
    {
        var command = _mapper.Map<CreateDailyLimitsCommand>(dto);
        return await _mediator.Send(command);
    }
    
    [HttpPut(Name = "UpdateDailyLimits")]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    public async Task<Result> Update(UpdateDailyLimitsDto dto)
    {
        var command = _mapper.Map<UpdateDailyLimitsCommand>(dto);
        return await _mediator.Send(command);
    }

}
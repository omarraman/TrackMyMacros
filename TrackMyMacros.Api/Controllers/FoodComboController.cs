using System.Diagnostics;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrackMyMacros.Application.Common;
using TrackMyMacros.Application.Features.Food.Queries.GetFoodList;
using TrackMyMacros.Application.Features.FoodCombo.Commands.Create;
using TrackMyMacros.Application.Features.FoodCombo.Commands.Delete;
using TrackMyMacros.Application.Features.FoodCombo.Commands.Update;
using TrackMyMacros.Application.Features.FoodCombo.Queries.GetFoodCombo;
using TrackMyMacros.Dtos;
using TrackMyMacros.Dtos.FoodCombo;

namespace TrackMyMacros.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FoodComboController:ControllerBase
{
    private IMediator _mediator;
    private readonly IMapper _mapper;

    public FoodComboController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
    
    [HttpGet()]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    public async Task<IReadOnlyList<GetFoodComboDto>> GetAll()
    {
        var foodListVms = await _mediator.Send(new GetFoodComboListQuery());
        return foodListVms;
    }
    
    [HttpGet("GetById/{id}")]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK)]  
    public async Task<IActionResult> Get(Guid id)
    {
        var getFoodComboDto = await _mediator.Send(new GetFoodComboQuery{Id = id});
        if (getFoodComboDto.HasNoValue)
        {
            return NotFound();
        }
        return Ok(getFoodComboDto.Value);
    }
    // [HttpPost(Name = "AddFoodCombo")]
    // [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    // public async Task<int> AddFoodCombo(CreateFoodComboDto createFoodComboDto)
    // {
    //    var result =  await _mediator.Send(_mapper.Map<CreateFoodComboCommand>(createFoodComboDto));
    //      return result.Value;
    // }
    //
    [HttpPut(Name = "UpdateFoodCombo")]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    public async Task<IActionResult> UpdateFoodCombo(UpdateFoodComboDto createFoodComboDto)
    {
        var result = await _mediator.Send(_mapper.Map<UpdateFoodComboCommand>(createFoodComboDto));
        if (result is ValidationErrorResult)
            return BadRequest(((ErrorResult)result).GetErrorString());
        return Ok();
    }
    
    [HttpPost(Name = "CreateFoodCombo")]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    public async Task<IActionResult> CreateFoodCombo(CreateFoodComboDto createFoodComboDto)
    {
        var result = await _mediator.Send(_mapper.Map<CreateFoodComboCommand>(createFoodComboDto));
        if (result is ValidationErrorResult<Guid>)
            return BadRequest(((ErrorResult<Guid>)result).GetErrorString());
        return Ok();
    }
    
    [HttpDelete( "{id}")]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    public async Task<IActionResult> DeleteFoodCombo(Guid id)
    {
        Debug.WriteLine("hey");
        var deleteFoodComboDto = new DeleteFoodComboDto { Id = id };
        await _mediator.Send(_mapper.Map<DeleteFoodComboCommand>(deleteFoodComboDto));
        return Ok();
    }
}


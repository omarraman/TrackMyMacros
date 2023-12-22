using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrackMyMacros.Application.Features.Food;
using TrackMyMacros.Application.Features.Food.Commands.CreateFood;
using TrackMyMacros.Application.Features.Food.Commands.UpdateFood;
using TrackMyMacros.Application.Features.Food.Queries;
using TrackMyMacros.Application.Features.Food.Queries.GetFoodList;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FoodController:ControllerBase
{
    private IMediator _mediator;
    private readonly IMapper _mapper;

    public FoodController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
    
    [HttpGet(Name = "GetAllFood")]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    public async Task<IReadOnlyList<FoodListItemDto>> Get()
    {
        var foodListVms = await _mediator.Send(new GetFoodListQuery());
        return foodListVms;
    }
    
    [HttpPost(Name = "AddFood")]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    public async Task<int> AddFood(CreateFoodDto createFoodDto)
    {
       var result =  await _mediator.Send(_mapper.Map<CreateFoodCommand>(createFoodDto));
         return result.Value;
    }
    
    [HttpPut(Name = "UpdateFood")]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    public async Task<IActionResult> UpdateFood(UpdateFoodDto createFoodDto)
    {
        await _mediator.Send(_mapper.Map<UpdateFoodCommand>(createFoodDto));
        return Ok();
    }
}
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrackMyMacros.Application.Features.Uom.Queries.GetUomList;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UomController:ControllerBase
{
    private IMediator _mediator;

    public UomController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet(Name = "GetAllUoms")]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    public async Task<IReadOnlyList<UomListItemDto>> Get()
    {
        var uomListVms = await _mediator.Send(new GetUomListQuery());
        return uomListVms;
    }
    
    // [HttpPost(Name = "AddUom")]
    // [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    // public async Task<int> AddUom(CreateUomDto createUomDto)
    // {
    //     await _mediator.Send(new CreateUomCommand { });
    // }
}
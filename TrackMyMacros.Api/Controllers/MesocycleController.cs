using AutoMapper;
using MediatR;
using TrackMyMacros.Application.Common;
using Microsoft.AspNetCore.Mvc;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.Application.Features.Mesocycle.Commands.Update;
using TrackMyMacros.Application.Features.Mesocycle.Queries.Get;
using TrackMyMacros.Application.Features.Mesocycle.Queries.GetList;

namespace TrackMyMacros.Api.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class MesocycleController : ControllerBase
    {
        private IMapper _mapper;
        private IMediator _mediator;
        public MesocycleController(IMapper mapper, IMediator mediator)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet()]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IReadOnlyList<GetMesocycleDto>> GetAll()
        {
            var mesocycleVms = await _mediator.Send(new GetMesocycleListQuery());
            return mesocycleVms;
        }

        [HttpGet("GetById/{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<ActionResult<GetMesocycleDto>> GetMesocycle(Guid id)
        {
            var mesocycle = await _mediator.Send(new GetMesocycleQuery { Id = id });
            return Ok(mesocycle.Value);
        }

        [HttpPut(Name = "UpdateMesocycle")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateMesocycle(UpdateMesocycleDto createMesocycleDto)
        {
            var result = await _mediator.Send(_mapper.Map<UpdateMesocycleCommand>(createMesocycleDto));
            if (result is ValidationErrorResult)
                return BadRequest(((ErrorResult)result).GetErrorString());
            return Ok();
        }
        //
        // [HttpPost(Name = "CreateMesocycle")]
        // [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        // public async Task<IActionResult> CreateMesocycle(CreateMesocycleDto createMesocycleDto)
        // {
        //     var result = await _mediator.Send(_mapper.Map<CreateMesocycleCommand>(createMesocycleDto));
        //     if (result is ValidationErrorResult<Guid>)
        //         return BadRequest(((ErrorResult<Guid>)result).GetErrorString());
        //     return Ok();
        // }

        // [HttpDelete("{id}")]
        // [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        // public async Task<IActionResult> DeleteMesocycle(Guid id)
        // {
        //     await _mediator.Send(new DeleteMesocycleCommand { Id = id });
        //     return Ok();
        // }
    }
}
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrackMyMacros.Dtos.Mesocycle;
using TrackMyMacros.Application.Features.Mesocycle.Queries.Get;

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

        [HttpGet("GetById/{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<ActionResult<GetMesocycleDto>> GetMesocycle(Guid id)
        {
            var mesocycle = await _mediator.Send(new GetMesocycleQuery { Id = id });
            return Ok(mesocycle.Value);
        }

    }
}
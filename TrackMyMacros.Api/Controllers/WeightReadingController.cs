using AutoMapper;
using MediatR;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Common;
using Microsoft.AspNetCore.Mvc;
using TrackMyMacros.Dtos.WeightReading;
using TrackMyMacros.Application.Features.WeightReading.Commands.Create;
using TrackMyMacros.Application.Features.WeightReading.Commands.Delete;
using TrackMyMacros.Application.Features.WeightReading.Commands.Update;
using TrackMyMacros.Application.Features.WeightReading.Queries.Get;
using TrackMyMacros.Application.Features.WeightReading.Queries.GetList;

namespace TrackMyMacros.Api.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class WeightReadingController : ControllerBase
    {
        private IMapper _mapper;
        private IMediator _mediator;
        public WeightReadingController(IMapper mapper, IMediator mediator)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet()]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IReadOnlyList<GetWeightReadingDto>> GetAll()
        {
            var weightReadingVms = await _mediator.Send(new GetWeightReadingListQuery());
            return weightReadingVms;
        }

        [HttpGet("GetById/{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<ActionResult<GetWeightReadingDto>> GetWeightReading(Guid id)
        {
            var weightreading = await _mediator.Send(new GetWeightReadingQuery { Id = id });
            return Ok(weightreading.Value);
        }

        [HttpPut(Name = "UpdateWeightReading")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateWeightReading(UpdateWeightReadingDto createWeightReadingDto)
        {
            var result = await _mediator.Send(_mapper.Map<UpdateWeightReadingCommand>(createWeightReadingDto));
            if (result is ValidationErrorResult)
                return BadRequest(((ErrorResult)result).GetErrorString());
            return Ok();
        }

        [HttpPost(Name = "CreateWeightReading")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateWeightReading(CreateWeightReadingDto createWeightReadingDto)
        {
            var result = await _mediator.Send(_mapper.Map<CreateWeightReadingCommand>(createWeightReadingDto));
            if (result is ValidationErrorResult<Guid>)
                return BadRequest(((ErrorResult<Guid>)result).GetErrorString());
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteWeightReading(Guid id)
        {
            await _mediator.Send(new DeleteWeightReadingCommand { Id = id} );
            return Ok();
        }
    }
}
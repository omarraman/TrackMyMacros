using AutoMapper;
using MediatR;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Common;
using Microsoft.AspNetCore.Mvc;
using TrackMyMacros.Dtos.Exercise;
/*using TrackMyMacros.Application.Features.Exercise.Commands.Create;
using TrackMyMacros.Application.Features.Exercise.Commands.Delete;
using TrackMyMacros.Application.Features.Exercise.Commands.Update;
using TrackMyMacros.Application.Features.Exercise.Queries.Get;*/
using TrackMyMacros.Application.Features.Exercise.Queries.GetList;

namespace TrackMyMacros.Api.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class ExerciseController : ControllerBase
    {
        private IMapper _mapper;
        private IMediator _mediator;
        public ExerciseController(IMapper mapper, IMediator mediator)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet()]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IReadOnlyList<GetExerciseDto>> GetAll()
        {
            var exerciseVms = await _mediator.Send(new GetExerciseListQuery());
            return exerciseVms;
        }

        /*
        [HttpGet("GetById/{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<ActionResult<GetExerciseDto>> GetExercise(Guid id)
        {
            var exercise = await _mediator.Send(new GetExerciseQuery { Id = id });
            return Ok(exercise.Value);
        }

        [HttpPut(Name = "UpdateExercise")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateExercise(UpdateExerciseDto createExerciseDto)
        {
            var result = await _mediator.Send(_mapper.Map<UpdateExerciseCommand>(createExerciseDto));
            if (result is ValidationErrorResult)
                return BadRequest(((ErrorResult)result).GetErrorString());
            return Ok();
        }

        [HttpPost(Name = "CreateExercise")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateExercise(CreateExerciseDto createExerciseDto)
        {
            var result = await _mediator.Send(_mapper.Map<CreateExerciseCommand>(createExerciseDto));
            if (result is ValidationErrorResult<Guid>)
                return BadRequest(((ErrorResult<Guid>)result).GetErrorString());
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteExercise(Guid id)
        {
            await _mediator.Send(new DeleteExerciseCommand { Id = id });
            return Ok();
        }*/
    }
}
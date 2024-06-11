using AutoMapper;
using MediatR;
using TrackMyMacros.Dtos;
using TrackMyMacros.Application.Common;
using Microsoft.AspNetCore.Mvc;
using TrackMyMacros.Dtos.Recipe;
using TrackMyMacros.Application.Features.Recipe.Commands.Create;
using TrackMyMacros.Application.Features.Recipe.Commands.Delete;
using TrackMyMacros.Application.Features.Recipe.Commands.Update;
using TrackMyMacros.Application.Features.Recipe.Queries.Get;
using TrackMyMacros.Application.Features.Recipe.Queries.GetList;

namespace TrackMyMacros.Api.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class RecipeController : ControllerBase
    {
        private IMapper _mapper;
        private IMediator _mediator;
        public RecipeController(IMapper mapper, IMediator mediator)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet()]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IReadOnlyList<GetRecipeDto>> GetAll()
        {
            var recipeVms = await _mediator.Send(new GetRecipeListQuery());
            return recipeVms;
        }

        [HttpGet("GetById/{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<ActionResult<GetRecipeDto>> GetRecipe(Guid id)
        {
            var recipe = await _mediator.Send(new GetRecipeQuery { Id = id });
            return Ok(recipe.Value);
        }

        [HttpPut(Name = "UpdateRecipe")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateRecipe(UpdateRecipeDto createRecipeDto)
        {
            var result = await _mediator.Send(_mapper.Map<UpdateRecipeCommand>(createRecipeDto));
            if (result is ValidationErrorResult)
                return BadRequest(((ErrorResult)result).GetErrorString());
            return Ok();
        }

        [HttpPost(Name = "CreateRecipe")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateRecipe(CreateRecipeDto createRecipeDto)
        {
            var result = await _mediator.Send(_mapper.Map<CreateRecipeCommand>(createRecipeDto));
            if (result is ValidationErrorResult<Guid>)
                return BadRequest(((ErrorResult<Guid>)result).GetErrorString());
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteRecipe(Guid id)
        {
            await _mediator.Send(new DeleteRecipeCommand { Id = id });
            return Ok();
        }
    }
}
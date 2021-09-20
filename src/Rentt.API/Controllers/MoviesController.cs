using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rentt.Application.Common.Dto;
using Rentt.Application.Movies.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rentt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ApiControllerBase
    {        
        /// <summary>
        /// Gets the list of movies
        /// </summary>        
        /// <response code="200">OK. Devuelve el objeto solicitado.</response>                
        [HttpGet("")]                
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IList<MovieDto>>> Get() {

            return Ok(await Mediator.Send(new GetMoviesQuery()));
        }
    }
}

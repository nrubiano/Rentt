using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Rentt.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet()]        
        public async Task<ActionResult> Get() {
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhoenixBL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoenixAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepositoryController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("getRepositoryByName")]
        public IActionResult getRepositoryByName(string text)
        {
            RepositoryBL bl = new RepositoryBL();
            var result = bl.getRepositoryByName(text);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

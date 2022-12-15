using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.Api.Controllers
{
    [ApiController]
    [Route("api/(controller)")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello world");
        }
    }
}

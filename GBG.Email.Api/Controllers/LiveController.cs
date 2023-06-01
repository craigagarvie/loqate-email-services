using Microsoft.AspNetCore.Mvc;

namespace GBG.Email.Api.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    [Route("/live")]
    public class LiveController : ControllerBase
    {
        public LiveController()
        {
        }

        [HttpGet]
        public object Get()
        {
            return Ok(new { message = "Hello from Email Service :)" });
        }
    }
}
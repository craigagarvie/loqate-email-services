using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBG.Email.Api.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    [Route("/startup")]
    public class StartupController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public StartupController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet]
        public object Get()
        {
            if (configuration["mailjetSingleRequestUrl"] == null)
            {
                return StatusCode(500, new { message = "Failed to startup" });
            }
            return Ok(new { message = "Success" });
        }
    }
}

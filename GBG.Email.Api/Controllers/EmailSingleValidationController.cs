using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBG.Email.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class MobileSigleValidationController : Controller
    {
        [HttpGet("ValidateEmail")]
        public async Task<ActionResult<string>> ValidateEmail(string email)
        {

            return Ok("Hello from Email Service");
        }
    }
}

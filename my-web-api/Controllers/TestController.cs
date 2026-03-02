using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace my_web_api.Controllers
{
    // [Route("api/[controller]")]
    [Route("api")]
    [ApiController]
    public class TestController : Controller
    {
        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok("Created Endpoint"); 
        }
    }
}


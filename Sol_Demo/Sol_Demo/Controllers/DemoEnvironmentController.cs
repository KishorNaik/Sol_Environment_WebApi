using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/demoenvironment")]
    [ApiController]
    public class DemoEnvironmentController : ControllerBase
    {
        private readonly IWebHostEnvironment webHostEnvironment = null;

        public DemoEnvironmentController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return base.Ok(webHostEnvironment.EnvironmentName);
        }
    }
}
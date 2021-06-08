using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sol_Demo.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly SecretModel secretModel = null;

        public DemoController(IOptions<SecretModel> options)
        {
            secretModel = options.Value;
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return base.Ok(secretModel.Key);
        }
    }
}
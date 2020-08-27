#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiSamples.NetCore.Interfaces;
using Microsoft.AspNetCore.Mvc; 
#endregion

namespace DiSamples.NetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        IService _service;
        public HomeController(IService service)
        {
            _service = service;
        }

        public IActionResult Get()
        {
            var result = _service.GetData();
            return Ok(result);
        }

        [Route("v2")]
        public IActionResult v2([FromServices] IService service)
        {
            var result = service.GetData();
            return Ok(result);
        }

    }
}

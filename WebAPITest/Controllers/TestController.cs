using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //[FromQuery]
        //public int inputStandard { get; set; }

        [HttpGet]
        public int Get([FromQuery] int input)
        {
            return input + 1;
        }

        [HttpDelete]
        public int Delete([FromQuery] char input, [FromQuery] char input2)
        {
            return input + input2;
        }
    }
}

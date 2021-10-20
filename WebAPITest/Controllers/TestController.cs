using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationLogic;

namespace WebAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //[FromQuery]
        //public int inputStandard { get; set; }

        [HttpGet]
        public string Get([FromQuery] int repeats, [FromQuery] string word)
        {
            return Class1.StringRepeat(repeats, word);
        }

        [HttpDelete]
        public int Delete([FromQuery] char input, [FromQuery] char input2)
        {
            return input + input2;
        }
    }
}

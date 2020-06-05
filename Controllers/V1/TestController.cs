using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eRead.Controllers.V1
{
    [ApiController]
    public class TestController : Controller
    {
        [HttpGet]
        [Route("api/ping")]
        public List<string> Hello()
        {
            return new List<string>
            {
                "Hey", "Hello"
            };
        }
    }
}

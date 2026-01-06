using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Say_hello.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class inputController : ControllerBase
    {
     [HttpGet]
     [Route("SayHello")]
     public string SayHello([FromQuery] string name)
     {
        return $"Hello, {name}!";
     }
    }
}
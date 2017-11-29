using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloCoreAPI.Controllers
{

    public class HelloController : Controller
    {
        [Route("hello")]
        [HttpGet]
        public string Hello()
        {
            return "Hello There!";
        }
    }
}
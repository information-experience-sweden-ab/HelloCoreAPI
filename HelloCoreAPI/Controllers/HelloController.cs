using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace HelloCoreAPI.Controllers
{
   [Authorize]
    public class HelloController : Controller
    {
        [Route("hello")]
        [HttpGet]
        public IActionResult Hello()
        {

            var scopes = HttpContext.User.FindFirst("http://schemas.microsoft.com/identity/claims/scope")?.Value;
            if (!string.IsNullOrEmpty("demo.read") && scopes != null && scopes.Split(' ').Any(s => s.Equals("demo.read")))
            {
                return Ok("Hello There");
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
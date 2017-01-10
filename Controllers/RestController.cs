using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Yosanai.Models;
using Yosanai.Config;

namespace Yosanai.Controllers
{

    public class RestController : Controller
    {
        private readonly HelloConfig _config;

        public RestController(IOptions<HelloConfig> options) {
            _config = options.Value;
        }

        [HttpGet("/api/helloREST/{msg}")]
        public IActionResult helloREST(string msg)
        {
            return Json(new Hello() { Msg = string.Format("{0}, Hi there, {1}", _config.Message, msg) });
        }

        [HttpPost("/api/helloREST")]
        public IActionResult helloRESTPost([FromBody] Hello hello)
        {
            return Json(new Hello() { Msg = string.Format("{0}, Hi there, {1}", _config.Message, hello.Msg) });
        }

    }
}
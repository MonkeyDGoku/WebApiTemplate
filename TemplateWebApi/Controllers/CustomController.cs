using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TemplateWebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CustomController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<CustomController> _logger;

        public CustomController(ILogger<CustomController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMessage")]
        public IActionResult Get()
        {
            var str = "Hi there !!!";
            return Ok(str);
        }
    }
}

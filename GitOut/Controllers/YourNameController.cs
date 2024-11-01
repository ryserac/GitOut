using Microsoft.AspNetCore.Mvc;

namespace GitOut.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class YourNameController : ControllerBase
    {
        private readonly ILogger<YourNameController> _logger;

        public YourNameController(ILogger<YourNameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var name = new YourName { Name = "Audrey Ryser" };
            return Ok(name);
        }
    }
}

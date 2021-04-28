using DevOps_Awarness.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevOps_Awarness.Controllers
{
    [ApiController]
    [Route("[api/controller]")]
    public class DevOpsController : ControllerBase
    {
        
        private readonly ILogger<DevOpsController> _logger;

        public DevOpsController(ILogger<DevOpsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("message")]
        [ProducesResponseType(200)]
        public IActionResult Get()
        {
            var response = new DevOpsResponse("This is an old message");

            _logger.LogInformation($"Message '{response.Message}' has been sent");

            return Ok(response.Message);
        }
    }
}

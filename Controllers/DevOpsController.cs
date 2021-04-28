using DevOps_Awarness.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

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
        [ProducesResponseType(500)]
        public IActionResult GetMessage()
        {
            try
            {
                var response = new DevOpsResponse("This is an old message");

                return Ok(response.Message);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                return StatusCode(500);
            }
            
        }
    }
}
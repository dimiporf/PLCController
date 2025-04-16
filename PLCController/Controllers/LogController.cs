using Microsoft.AspNetCore.Mvc;
using PLCController.Services.IServices;

namespace PLCController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LogController : ControllerBase
    {
        private readonly ILogService _log;

        public LogController(ILogService log) => _log = log;

        [HttpGet]
        public IActionResult GetLogs() => Ok(_log.GetAllLogs());
    }

}

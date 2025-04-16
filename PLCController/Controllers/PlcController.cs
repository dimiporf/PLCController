using Microsoft.AspNetCore.Mvc;
using PLCController.Models;
using PLCController.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PLCController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlcController : ControllerBase
    {
        private readonly IPlcService _plc;

        public PlcController(IPlcService plc)
        {
            _plc = plc;
        }

        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            var status = _plc.ReadInputsAndOutputs();
            return Ok(status);
        }

        [HttpPost("command")]
        public IActionResult SendCommand([FromBody] PlcCommandRequest request)
        {
            var success = _plc.WriteOutput(request.MotorOn, request.State);
            return success ? Ok("OK") : StatusCode(500, "Failed to write to PLC");
        }
    }

}

using Microsoft.AspNetCore.Mvc;
using PLCController.Models;
using PLCController.Services.IServices;

[ApiController]
[Route("api/[controller]")]
public class PlcController : ControllerBase
{
    private readonly IPlcService _plc;
    private readonly ILogService _log;

    public PlcController(IPlcService plc, ILogService log)
    {
        _plc = plc;
        _log = log;
    }

    [HttpGet("status")]
    public IActionResult GetStatus() => Ok(_plc.ReadInputsAndOutputs());

    [HttpPost("command")]
    public IActionResult SendCommand([FromBody] PlcCommandRequest request)
    {
        var success = _plc.WriteOutput(request.OutputName, request.State);

        // ✍️ Καταγραφή στο log
        string entry = $"[{DateTime.Now:HH:mm:ss}] UI Command → Output: '{request.OutputName}', State: {request.State}";
        _log.Log(entry);

        return success ? Ok("OK") : StatusCode(500, "Failed");
    }
}

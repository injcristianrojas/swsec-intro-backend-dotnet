using Microsoft.AspNetCore.Mvc;
using swsec_intro_backend_dotnet.Helpers;

namespace swsec_intro_backend_dotnet.Controllers;

[ApiController]
public class HealthCheckController : ControllerBase
{
    [HttpGet("/healthcheck/{file=healthcheck}")]
    public IActionResult HealthCheck(string file) {
        string output = ShellCommandExecutor.RunShellCommand("cat " + file);
        return Ok(output);
    }
}
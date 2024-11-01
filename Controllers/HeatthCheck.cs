using Microsoft.AspNetCore.Mvc;
using swsec_intro_backend_dotnet.Helpers;

namespace swsec_intro_backend_dotnet.Controllers;

[ApiController]
public class HealthCheckController : ControllerBase
{
    [HttpGet("/healthcheck/{file?}")]
    public IActionResult HealthCheck(string file = "healthcheck") {
        string output = ShellCommandExecutor.RunShellCommand("cat " + file);
        return Ok(output);
    }
}
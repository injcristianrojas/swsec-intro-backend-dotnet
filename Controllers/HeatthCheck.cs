using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class HealthCheckController : ControllerBase
{
    [HttpGet("/healthcheck/{file?}")]
    public IActionResult HealthCheck(string file = "healthcheck") {
        string output = ShellCommandExecutor.RunShellCommand("cat " + file);
        return Ok(output);
    }
}
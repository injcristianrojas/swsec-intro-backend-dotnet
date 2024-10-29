using Microsoft.AspNetCore.Mvc;
using swsec_intro_backend_dotnet.Helpers;

namespace swsec_intro_backend_dotnet.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly JwtHelper _jwtHelper;

    public AuthController(JwtHelper jwtHelper)
    {
        _jwtHelper = jwtHelper;
    }

    [HttpPost("/login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        // Validate user credentials (this example assumes valid credentials)
        var userId = "exampleUserId"; // Replace with actual user ID retrieval logic

        var token = _jwtHelper.GenerateToken(userId);
        return Ok(new { Token = token });
    }
}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
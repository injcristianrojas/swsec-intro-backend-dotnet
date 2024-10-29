using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using swsec_intro_backend_dotnet.Data;
using swsec_intro_backend_dotnet.Helpers;
using swsec_intro_backend_dotnet.Models;

namespace swsec_intro_backend_dotnet.Controllers;

[ApiController]
public class AuthController : ControllerBase
{
    private readonly JwtHelper _jwtHelper;
    private readonly AppDbContext _context;

    public AuthController(JwtHelper jwtHelper, AppDbContext context)
    {
        _jwtHelper = jwtHelper;
        _context = context;
    }

    [HttpPost("/api/v2/login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        List<User> users = _context.Users.FromSqlRaw($"SELECT * FROM users WHERE username = '{request.Username}' AND password = '{request.Password}'").ToList();
        if (users.Count < 1)
            return Unauthorized("UNAUTHORIZED");

        var token = _jwtHelper.GenerateToken(users[0].Username, users[0].Type);
        return Ok(new { Token = token });
    }
}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}
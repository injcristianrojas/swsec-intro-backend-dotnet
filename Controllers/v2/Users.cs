using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using swsec_intro_backend_dotnet.Data;

namespace swsec_intro_backend_dotnet.Controllers.v2;

[ApiController]
[Authorize]
public class UserController : ControllerBase
{
    private readonly AppDbContext _context;

    public UserController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("/api/v2/users/type/{type}")]
    public IActionResult GetByType(int type)
    {
        var result = _context.Users.FromSqlRaw($"SELECT * FROM users WHERE type = {type}").Select(e => new {e.Username, e.Type}).ToList();
        return Ok(result);
    }
}
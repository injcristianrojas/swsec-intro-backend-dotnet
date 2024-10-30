using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using swsec_intro_backend_dotnet.Data;
using swsec_intro_backend_dotnet.Models;

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
    public List<User> GetByType(int type)
    {
        return _context.Users.FromSqlRaw($"SELECT * FROM users WHERE type = {type}").ToList();
    }
}
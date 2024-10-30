using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using swsec_intro_backend_dotnet.Data;
using swsec_intro_backend_dotnet.Models;

namespace swsec_intro_backend_dotnet.Controllers.v1;

[ApiController]
public class UserController : ControllerBase
{
    private readonly AppDbContext _context;

    public UserController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("/api/v1/users/type/{type}")]
    public List<User> GetByType(int type)
    {
        return _context.Users.FromSqlRaw($"SELECT * FROM users WHERE type = {type}").ToList();
    }

    [HttpGet("/api/v1/users/name/{username}")]
    public List<User> GetByUsername(string username)
    {
        return _context.Users.FromSqlRaw($"SELECT * FROM users WHERE username = '{username}'").ToList();
    }
}
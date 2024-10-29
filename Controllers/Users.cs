using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using swsec_intro_backend_dotnet.Data;
using swsec_intro_backend_dotnet.Models;

namespace swsec_intro_backend_dotnet.Controllers;

[ApiController]
[Route("[controller]")]

public class UserController : ControllerBase
{
    private readonly AppDbContext _context;

    public UserController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("/users/{type}")]
    public List<User> GetByType(int type)
    {
        return _context.Users.FromSqlRaw($"SELECT * FROM users WHERE type = {type}").ToList();
    }

    [HttpPost("/login")]
    public ActionResult Login(User user)
    {
        Console.WriteLine(user.Username + "-" + user.Password);
        List<User> users = _context.Users.FromSqlRaw($"SELECT * FROM users WHERE username = '{user.Username}' AND password = '{user.Password}'").ToList();
        return users.Count > 0 ? Ok("Holi") : Unauthorized("UNAUTHORIZED");
    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
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

    [HttpGet("/api/v1/users/name/{username}")]
    public IActionResult GetByUsername(string username)
    {
        var returnList = new List<object>();
        using (var connection = _context.Database.GetDbConnection())
        {
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT Username, Type FROM users WHERE username = '" + username + "'";
            using SqliteDataReader reader = (SqliteDataReader)command.ExecuteReader();
            while (reader.Read())
            {
                returnList.Add(new {Username = reader[0], Type = reader[1]});
            }
        }
        return Ok(returnList);
    }
}
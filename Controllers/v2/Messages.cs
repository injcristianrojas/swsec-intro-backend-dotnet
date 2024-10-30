using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using swsec_intro_backend_dotnet.Data;
using swsec_intro_backend_dotnet.Models;

namespace swsec_intro_backend_dotnet.Controllers.v2;

[ApiController]
[Authorize]
public class MessageController : ControllerBase
{
    private readonly AppDbContext _context;

    public MessageController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("/api/v2/messages")]
    public List<Post> GetMessages()
    {
        return _context.Messages.ToList();
    }

    [HttpPost("/api/v2/messages/new")]
    public IActionResult PostMessage([FromBody] MessageRequest request)
    {
        _context.Add<Post>(new Post { Message = request.Text });
        _context.SaveChanges();
        return Ok(new { status = "OK" });
    }

}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using swsec_intro_backend_dotnet.Data;
using swsec_intro_backend_dotnet.Models;

namespace swsec_intro_backend_dotnet.Controllers.v1;

[ApiController]
public class MessageController : ControllerBase
{
    private readonly AppDbContext _context;

    public MessageController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("/api/v1/messages")]
    public List<Message> GetMessages()
    {
        return _context.Messages.ToList();
    }

    [HttpPost("/api/v1/messages/add")]
    public IActionResult PostMessage([FromBody] MessageRequest request)
    {
        _context.Add<Message>(new Message { Text = request.Text });
        _context.SaveChanges();
        return Ok(new { status = "OK" });
    }

}

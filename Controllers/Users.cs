using Microsoft.AspNetCore.Mvc;
using swsec_intro_backend_dotnet.Models;

namespace swsec_intro_backend_dotnet.Controllers;

[ApiController]
[Route("[controller]")]

public class UserController : ControllerBase {
    [HttpGet(Name = "GetUsers")]
    public User Get() {
        return new User{Id=0, Username="test", Password="123"};
    }
}
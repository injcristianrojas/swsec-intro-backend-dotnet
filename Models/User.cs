namespace swsec_intro_backend_dotnet.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int Type { get; set; }
}

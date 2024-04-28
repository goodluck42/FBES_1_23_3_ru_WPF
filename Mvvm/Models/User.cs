namespace Mvvm.Models;

public class User
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string Login { get; set; } = null!;
    public string Password { get; set; } = null!;
}
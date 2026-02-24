namespace EFLibrary.Models;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Email { get; set; } = null!;
    public string Login { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

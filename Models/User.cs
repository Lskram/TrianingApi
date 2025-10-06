namespace ControllAPI.Models;

public class User
{
    // properties
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string FullName { get; set; }

    // Constructor
    public User() { }
}
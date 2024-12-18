namespace UniversitySystem;

public class User {
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }

    protected User(int id, string username, string email, string password, string role) {
        Id = id;
        Username = username;
        Email = email;
        Password = password;
        Role = role;
    }
}
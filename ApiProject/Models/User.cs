// User Model
namespace ApiProject.Models;
public class User {
    public int Id {get; set;}
    public string Username {get; set;}
    public string Password {get; set;}
    public UserRole.Role Role {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
    public User(string username, string password, UserRole.Role role) {
        Username = username;
        Password = password;
        Role = role;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
}

public class UserRole {
    public enum Role {
        Admin,
        User,
        Editor,
        Guest,
    }
}
// User Model
namespace ApiProject.Models;
public class User {
    public int Id {get; set;}
    public string? Username {get; set;}
    public string? Password {get; set;}
    public string? Role {get; set;}
    public DateTime Created {get; set;}
    public DateTime Updated {get; set;}
    public User() {
        Created = DateTime.Now;
        Updated = DateTime.Now;
    }
}
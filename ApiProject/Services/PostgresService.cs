using ApiProject.Models;
using Npgsql;

namespace ApiProject.Services;
public static class PostgresService {
    public static NpgsqlConnection PsqlConnect() {
       string connectionString ="Host=localhost;Port=5432;Username = lavonsampson; Password='Victory';Database=api";
       return new NpgsqlConnection(connectionString); 
    }

    public static List<User> GetUsers() {
        List<User> users = new List<User>();
        try {
            using (var connection = PsqlConnect()) {
                connection.Open();
                Console.WriteLine("Connection to Database is successfull");
                using (var command = new NpgsqlCommand("SELECT * FROM users", connection)) {
                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            int id = (int)reader["id"];
                            string username = (string)reader["username"];
                            string password = (string)reader["password"];
                            UserRole.Role role = (UserRole.Role)reader["role"];
                            DateTime created = (DateTime)reader["created"];
                            DateTime updated = (DateTime)reader["updated"];

                            users.Add(new User(username, password, role));
                        }
                    }
                }
            }
        } catch (NpgsqlException ex) {
            Console.Error.WriteLine("Database error: ", ex.Message);
        }
        return users;
    }
}
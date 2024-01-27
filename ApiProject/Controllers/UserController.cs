// User Controller
using ApiProject.Models;
using ApiProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers;
[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase {
    public UsersController(){}

    // Get Users
    [HttpGet]
    public IActionResult GetUsers() {
        List<User> users = PostgresService.GetUsers();
        return Ok(users);
    }

    // Get Users by id

    // POST Users

}
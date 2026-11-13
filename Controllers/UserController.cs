using Microsoft.AspNetCore.Mvc;
using PraticaRabbitMQ.Models;

namespace PraticaRabbitMQ.Controllers;

[ApiController]
[Route("api/users")]
public sealed class UserController : ControllerBase
{
    private static readonly List<User> Users = [];
    private static int _nextId = 1;

    [HttpGet]
    public ActionResult<IReadOnlyList<User>> GetAll() => Ok(Users);

    [HttpPost]
    public ActionResult<User> Create(CreateUserRequest request)
    {
        var user = new User(_nextId++, request.Name.Trim(), request.Email.Trim());
        Users.Add(user);
        return Created($"/api/users/{user.Id}", user);
    }

    public sealed record CreateUserRequest(string Name, string Email);
}

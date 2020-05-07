using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Wombo.Domain.Users;

namespace Wombo.Api.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {
        private readonly User[] _users;

        public UsersController()
        {
            _users = new User[]
            {
                new User(1, "Tiago", "tiago@email.com" ),
                new User(2, "Bruna", "bruna@email.com" ),
                new User(3, "Iran", "iran@email.com"),
                new User(4, "Rogério", "rogerio@email.com"),
                new User(5, "Ricardo", "ricardo@email.com"),
                new User(6, "Ronaldo", "ronaldo@email.com"),
                new User(7, "Helene", "helene@email.com"),
            };
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_users);
        }

        [HttpGet("{userId}")]
        public IActionResult GetUsers(int userId)
        {
            var user = _users.FirstOrDefault(user => user.Id == userId);

            if (user is null)
            {
                return NotFound();
            }

            return Ok(user);
        }
    }
}

using System;
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
            };
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_users);
        }
    }
}

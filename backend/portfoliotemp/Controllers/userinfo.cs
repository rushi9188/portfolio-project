using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApisDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private static List<User> users = new List<User>();

        [HttpPost]
        public IActionResult PostUser([FromBody] User user)
        {
            users.Add(user);
            return CreatedAtAction(nameof(PostUser), user);
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(users);
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
    }
}

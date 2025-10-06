using Microsoft.AspNetCore.Mvc;
using ControllAPI.Models;
using System.Collections.Generic;

namespace ControllAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase

    {
        private static readonly List<User> _users = new List<User>
        {
            new User
                {
                    Id = 1,
                    Username = "JohnDoe",
                    Email = "josh@gmail.com",
                    FullName = "John Doe",
                },
                new User
                {
                    Id = 2,
                    Username = "Samit",
                    Email = "Samit@gmail.com",
                    FullName = "Samit Doe",
                },
                new User
                {
                    Id = 3,
                    Username = "Chana",
                    Email = "Chana@gmail.com",
                    FullName = "Chana Doe",
                }
        };
        //Get all users
        // GET: api/User
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            foreach (var user in _users)
            {
                Console.WriteLine($"{user.Id}, {user.Username}");
            }

            return Ok(_users);
        }
    }
    
}
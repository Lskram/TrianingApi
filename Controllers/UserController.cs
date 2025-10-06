using Microsoft.AspNetCore.Mvc;
using ControllAPI.Models;
using System.Collections.Generic;

namespace ControllAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // GET: api/User
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            var users = new List<User>
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
                    Id = 1,
                    Username = "Samit",
                    Email = "Samit@gmail.com",
                    FullName = "Samit Doe",
                },
                new User
                {
                    Id = 1,
                    Username = "Chana",
                    Email = "Chana@gmail.com",
                    FullName = "Chana Doe",
                }
            };

            return Ok(users);
        }
    }
}
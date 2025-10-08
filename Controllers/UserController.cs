using Microsoft.AspNetCore.Mvc;
using ControllAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System;


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
            // foreach (var user in _users)
            // {
            //     Console.WriteLine($"{user.Id}, {user.Username}");
            // }

            return Ok(_users);
        }
        //Get user by id   
        // GET: api/User/1
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            // LINQ คืออะไร
            // LINQ (Language Integrated Query) เป็นฟีเจอร์ในภาษา C# ที่ช่วยให้เราสามารถเขียนคำสั่งเพื่อดึงข้อมูลจากแหล่งข้อมูลต่าง ๆ เช่น อาร์เรย์, คอลเลกชัน, ฐานข้อมูล หรือ XML ได้อย่างง่ายดายและมีประสิทธิภาพ
            // โดยใช้ไวยากรณ์ที่คล้ายกับ SQL ทำให้โค้ดดูสะอาดและเข้าใจง่ายขึ้น
            // ตัวอย่างการใช้งาน LINQ
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        // Create a new user
        // POST: api/User
        [HttpPost]
        public ActionResult<User> CreateUser([FromBody] User user)
        {
            _users.Add(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }
        // Update user by id
        // PUT: api/User/1
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("หดหู่ว่ะ");
            }
            //validate user id
            if (id != user.Id)
            {
                return BadRequest();
            }

            //find user by id
            var existingUser = _users.FirstOrDefault(u => u.Id == id);
            if (existingUser == null)
            {
                return NotFound();
            }
            existingUser.Username = user.Username;
            existingUser.Email = user.Email;
            existingUser.FullName = user.FullName;
            
            // Return updated user
            return Ok(existingUser);
        }
        //Delete user by id
        // DELETE: api/User/1
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound("ไม่มีไรให้ลบอ่ะ ลองเช็คดูใหม่");
            }
            _users.Remove(user);
            return NoContent();
        }


    }
}
# 🛴 Workshop .NET 8 with NextJS14  

RESTful API Training Workshop with **.NET 8** and **NextJS 14**  

---

## ✈ DAY 1 – เนื้อหาหลัก
1. แนะนำ .NET Core 8  
2. การสร้าง .NET 8 Rest API  

---

## 🔍 .NET Core 8 Overview  

### 🔹 Minimal API  
**เหมาะกับงานเล็ก / prototype**
- ✅ โค้ดสั้น กระชับ  
- ✅ พัฒนาได้รวดเร็ว  
- ✅ รองรับ async/await  

❌ ตัวเลือกการตั้งค่าจำกัด  
❌ ไม่เหมาะกับ API ขนาดใหญ่  

---

### 🔹 Controller-based API  
**เหมาะกับงานใหญ่ / production**
- ✅ โครงสร้างชัดเจน  
- ✅ รองรับ middleware และ unit test  
- ✅ ปรับแต่งได้หลากหลาย  

❌ โค้ดยาวและซับซ้อนกว่า  
❌ พัฒนาได้ช้ากว่า Minimal API  

---

## 🚀 การสร้าง .NET 8 REST API  

### ✅ Minimal API
```bash
dotnet new webapi -o MinimalAPI
✅ Controller-based API
dotnet new webapi --use-controllers -o ControllerAPI

✅ Run Project
dotnet watch run

👨‍💻 ตัวอย่าง Controller-based API
📌 Model: User
namespace WebApi.Models;
public class User {
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string Fullname { get; set; }
}

📌 Controller: UserController
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase {

    [HttpGet]
    public ActionResult<List<User>> GetUsers() {
        var users = new List<User> {
            new User { Id = 1, Username = "john", Email = "john@email.com", Fullname = "John Doe" },
            new User { Id = 2, Username = "samit", Email = "samit@email.com", Fullname = "Samit Koyom" }
        };
        return Ok(users);
    }
}

🎯 สรุป

.NET 8 มี 2 รูปแบบการสร้าง API → Minimal API และ Controller-based API

Minimal API → โค้ดสั้น เหมาะกับงานเล็ก

Controller-based API → โครงสร้างชัดเจน เหมาะกับงานใหญ่

ตัวอย่าง UserController แสดงการสร้าง API ง่าย ๆ

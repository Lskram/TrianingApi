📌 TrianingApi

RESTful API พัฒนาโดยใช้ .NET 8 (ASP.NET Core Web API)
โครงการนี้สร้างขึ้นเพื่อการฝึกฝน (Training API) และสามารถนำไปขยายต่อสำหรับงานจริงได้

🚀 Features

✅ พัฒนาโดยใช้ .NET 8

✅ โครงสร้างโปรเจ็กต์แบบ Clean & Maintainable

✅ รองรับ appsettings.json สำหรับ config

✅ รองรับการทดสอบ API ผ่านไฟล์ .http

✅ พร้อมต่อยอดเพิ่ม Authentication / Database / Swagger

📂 Project Structure
TrianingApi/
│── Properties/                # Project metadata
│── bin/Debug/net8.0/          # Build output
│── obj/                       # Build objects
│── ControllAPI.csproj         # Project file
│── ControllAPI.http           # API test file
│── ControllAPI.sln            # Solution file
│── Program.cs                 # Entry point
│── appsettings.json           # Config file
│── appsettings.Development.json
│── README.md                  # Documentation

⚡ Getting Started
1️⃣ Clone Project
git clone https://github.com/yourusername/TrianingApi.git
cd TrianingApi

2️⃣ Run the API
dotnet run


API จะเริ่มทำงานที่:
👉 https://localhost:5001
👉 http://localhost:5000

🛠️ Requirements

.NET 8 SDK

Visual Studio / VS Code

📖 Usage Example

ทดสอบ API ได้ผ่านไฟล์ ControllAPI.http หรือใช้ Postman / curl

GET https://localhost:5001/api/values
Accept: application/json

🌱 Next Steps

 เพิ่ม Swagger UI

 เพิ่ม Database (EF Core / Dapper)

 เพิ่ม Authentication (JWT)

 เพิ่ม Unit Tests

👨‍💻 Author

Developed by Your Name

✉️ Contact: your-email@example.com

🌐 GitHub: yourusername

📜 License

This project is licensed under the MIT License – feel free to use and modify.

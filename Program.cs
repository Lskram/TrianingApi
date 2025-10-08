var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

try
{
    // Allow port override through environment variable
    var port = Environment.GetEnvironmentVariable("PORT") ?? "5091";
    builder.WebHost.UseUrls($"http://localhost:{port}");
    
    app.Run();
}
catch (IOException ex) when (ex.Message.Contains("address already in use"))
{
    var currentPort = Environment.GetEnvironmentVariable("PORT") ?? "5091";
    Console.WriteLine($"Error: Port {currentPort} is already in use. Try setting a different port using the PORT environment variable.");
    Environment.Exit(1);
}
catch (Exception ex)
{
    Console.WriteLine($"Error starting the application: {ex.Message}");
    Environment.Exit(1);
}

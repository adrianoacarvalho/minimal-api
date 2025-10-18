using Microsoft.EntityFrameworkCore;
using MininalApi.Infraestrutura.Db;
using MininalApi.DTOs;

var builder = WebApplication.CreateBuilder(args);

builder.Services/


builder.Services.AddDbContext<DbContexto>(options => 
    options.UseMySql(builder.Configuration.GetConnectionString("mysql"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (MininalApi.DTOs.LoginDTO login) =>
{
    
    if (login.Email == "adm@teste.com" && login.Password == "123456")
    {
        return Results.Ok("Login successful");
    }
    return Results.Unauthorized();
});

app.Run();




var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDTO login) =>
{
    
    if (login.Email == "adm@teste.com" && login.Password == "123456")
    {
        return Results.Ok("Login successful");
    }
    return Results.Unauthorized();
});

app.Run();

public class LoginDTO
{
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
}



var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Your API endpoint
app.MapGet("/api/test", () =>
{
    return Results.Ok(new { message = "Hello from WebApp2 updated" });
});

app.Run();

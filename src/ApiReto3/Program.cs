var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Json(new { message = "Hello World" }));

app.Run();

public partial class Program { }

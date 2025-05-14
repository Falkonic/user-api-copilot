using UserApi.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.UseLoggingMiddleware(); // eigene Middleware
app.MapControllers();

app.Run();
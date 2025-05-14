var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("downloads", () => "Downloads");
app.MapPut("/", () => "This is a put");
app.MapDelete("/", () => "This is a delete");
app.MapGet("/users/{userId}/posts/{slug}", (int userId, string slug) =>{
    return $"User ID: {userId}, Post ID: {slug}";
    
});
app.MapPost("/", () => "This is a post");
app.Run();

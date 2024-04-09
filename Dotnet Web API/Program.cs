using Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

var users = new List<User>();

// Get All Users
app.MapGet("/api/users", () =>
{
    return users;
})
.WithName("GetAllUsers")
.WithOpenApi();

// Get User by Id
app.MapGet("/api/users/{id}", (int id) => 
{
    foreach(var u in users) 
    { 
        Console.WriteLine(u);
    }
    var user = users.Find(user => user.Id == id);

    return Results.Ok(user);
});

app.Run();



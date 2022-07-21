using Services;
using DAO;
using Models;
using WebAPI.Controllers;

var builder = WebApplication.CreateBuilder(args);

//builder.Configuration.GetConnectionString("ERS_DB");
//depedency injection container
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<TicketService>();
builder.Services.AddScoped<AuthController>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");

app.MapGet("/users", (UserService service) => 
{
	return service.GetAllUsers();
});

app.MapPost("/register", (Users user, AuthController controller) => 
{
	return controller.RegisterUser(user);
});

app.MapPost("/login", (string username, string password, AuthController controller) => 
{
	return controller.Login(username, password);
});

app.Run();

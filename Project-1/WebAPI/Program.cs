using Services;
using DAO;
using Models;
using WebAPI.Controllers;

var builder = WebApplication.CreateBuilder(args);

//builder.Configuration.GetConnectionString("ERS_DB");
//depedency injection container
builder.Services.AddScoped<UserController>();
builder.Services.AddScoped<TicketService>();
builder.Services.AddScoped<AuthController>();
builder.Services.AddScoped<UserService>(); //is it not weird that I have to have service and controller as dependency?
builder.Services.AddScoped<AuthService>(); //do we need to deploy this to the web through azure?


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello World!");

app.MapGet("/users", (UserController controller) => //this is not very clear on trello
{
	return controller.GetAllUsers();
});

//this is a query parameter, it has a parameter to actually be implemented
app.MapGet("/user", (string username, UserController controller) =>
{
	return controller.GetByUsername(username);
});

//this is route parameter
app.MapGet("/user/{ID}", (int ID, UserController controller) =>
{
	return controller.GetByUserID(ID);
});

app.MapPost("/register", (Users user, AuthController controller) => //couldn't we technically do these through query param?
{
	return controller.RegisterUser(user);
});

app.MapPost("/login", (string username, string password, AuthController controller) => 
{
	return controller.Login(username, password);
});

app.Run();

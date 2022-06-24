using Models;

User newUser = new User("Sammy", 25, "house566", "Employee");
//newUser.UserName = "Billy";


Console.WriteLine("Username: " + newUser.UserName);
Console.WriteLine("User ID: " + newUser.UserID);
Console.WriteLine("Password: " + newUser.Password);
Console.WriteLine("Role: " + newUser.Role);
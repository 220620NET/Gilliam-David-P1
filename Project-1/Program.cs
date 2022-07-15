using System.Data.SqlClient;
using Models;
using UDAO;
using System.Collections.Generic;

/*Console.WriteLine("Enter your username:");
string a = Console.ReadLine();

Console.WriteLine("Enter your User ID:");
int b = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Enter your password:");
string c = Console.ReadLine();

Console.WriteLine("Enter your role:");
string d = Console.ReadLine();


User newUser = new User(a, b, c, d);
//newUser.UserName = "Billy";


Console.WriteLine("Username: " + newUser.UserName);
Console.WriteLine("User ID: " + newUser.UserID);
Console.WriteLine("Password: " + newUser.Password);
Console.WriteLine("Role: " + newUser.Role); */


UsersDAO useraccess = new UsersDAO();

Users user_data = new Users("Anthony", "zionz4112", "Employee");

useraccess.CreateUser(user_data);


List<Users> users = useraccess.GetAllUsers();

foreach (Users user in users){
	Console.WriteLine(user);
}
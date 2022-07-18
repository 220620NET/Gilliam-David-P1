using System.Data.SqlClient;
using Models;
using DAO;
using System.Collections.Generic;
using Services;

UsersDAO useraccess = new UsersDAO();
TicketsDAO ticketaccess = new TicketsDAO();

/*Users user_data = new Users("Anthony", "zionz4112", "Employee");

useraccess.CreateUser(user_data);

Users userinfo = useraccess.GetByUsername("Susan");
Console.WriteLine(userinfo);

/*List<Users> users = useraccess.GetAllUsers();

foreach (Users user in users){
	Console.WriteLine(user);
}*/

//Tickets ticket_data = new Tickets(5, "Upcoming leadership conference", 210.33);

//ticketaccess.CreateTicket(ticket_data);

/*ticketaccess.UpdateTicket(4, "Denied", 4);

List<Tickets> tickets = ticketaccess.GetAllTickets();

foreach (Tickets ticket in tickets){
	Console.WriteLine(ticket);
}*/

/*Users userinfo = useraccess.GetByUserID(2);
Console.WriteLine(userinfo);

Tickets ticketinfo = ticketaccess.GetByTicketID(2);
Console.WriteLine(ticketinfo);
List<Tickets> ticketinfo = ticketaccess.GetByTicketStatus("Denied");
foreach (Tickets ticket in ticketinfo){
	Console.WriteLine(ticket);
}*/

AuthService test = new AuthService();
//Users user = test.Login("Zack", "doggo402");
//Console.WriteLine(user);
/*Users user_data = new Users("Sally", "glob0976", "Manager");

Users meh = test.RegisterUser(user_data);
Console.WriteLine(meh.userID);*/

/*List<Users> users = useraccess.GetAllUsers();

foreach (Users user in users){
	Console.WriteLine(user);
}*/





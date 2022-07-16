using System.Data.SqlClient;
using Models;
using System.Collections.Generic;

namespace DAO;

//The purpose of this layer is to execute the SQL statements to the database

public class TicketsDAO 
{
	//the connection string from azure (class level variable)
    string connectionString = "Server=tcp:davidgserver.database.windows.net,1433;Initial Catalog=DavidG;Persist Security Info=False;User ID=sqluser;Password=p4ssw0rd!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";	
	public List<Tickets> GetAllTickets() {
		List<Tickets> tickets = new List<Tickets>();

        //this defines the sql statement we'd like to execute
        string sql = "select * from ERS.tickets;"; 

		//data type for an active connection
		SqlConnection connection = new SqlConnection(connectionString);
		//data type to reference the sql command you want to do to a specific connection
		SqlCommand command = new SqlCommand(sql, connection);

		try 
		{
		   //opening the connection to the database
		   connection.Open();
		   //storing the result set of a DQL statement into a variable
		   SqlDataReader reader = command.ExecuteReader(); 
		   while (reader.Read()) 
		   {
		   	  tickets.Add(new Tickets((int)reader[0], (int)reader[1], (int)reader[2], (string)reader[3], (string)reader[4], (double)reader[5]));
		   }
		   reader.Close();
		   connection.Close();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}

           return tickets;
	}
	public void CreateTicket(Tickets ticket) {
		//this defines the sql statement we'd like to execute
        string sql = "insert into ERS.tickets (author_ID, ticketDescription, ticketAmount) values (@author_ID, @ticketDescription, @ticketAmount);";

		//data type for an active connection
		SqlConnection connection = new SqlConnection(connectionString);
		//data type to reference the sql command you want to do to a specific connection
		SqlCommand command = new SqlCommand(sql, connection);
		command.Parameters.AddWithValue("@author_ID", ticket.authorID); //AddWithValue assigns variable values
        command.Parameters.AddWithValue("@ticketDescription", ticket.ticketDescription); //could I just reference an older value from the database here?
        command.Parameters.AddWithValue("@ticketAmount", ticket.ticketAmount); //AddWithValue assigns variable values
		try 
		{
		   //opening the connection to the database
		   connection.Open();
		   //this is for DML statements
		   int rowsAffected = command.ExecuteNonQuery();
		  
		   if (rowsAffected != 0)
		   {
		   	Console.WriteLine("This ticket was submitted by user #" + ticket.authorID);
		   }
		 
		   connection.Close();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}	
	}
	public void UpdateTicket(int ticketID, string ticketStatus, int resolverID) {
		//this defines the sql statement we'd like to execute
        string sql = "update ERS.tickets set resolver_ID = @resolver_ID, ticketStatus = @ticketStatus where ticketID = @ticketID;";
        
		//data type for an active connection
		SqlConnection connection = new SqlConnection(connectionString);
		//data type to reference the sql command you want to do to a specific connection
		SqlCommand command = new SqlCommand(sql, connection);
		command.Parameters.AddWithValue("@ticketID", ticketID);
		command.Parameters.AddWithValue("@ticketStatus", ticketStatus);
		command.Parameters.AddWithValue("@resolver_ID", resolverID); //AddWithValue assigns variable values
       
		try 
		{
		   //opening the connection to the database
		   connection.Open();
		   //this is for DML statements
		   int rowsAffected = command.ExecuteNonQuery();
		  
		   if (rowsAffected != 0)
		   {
		   	Console.WriteLine("Ticket ID#" + ticketID + " has been updated by user #" + resolverID);
		   }
		 
		   connection.Close();		   
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		
	}
	public Tickets GetByTicketID(int ID) {
    	string sql = "select * from ERS.tickets where ticketID = @ID;";

    	SqlConnection connection = new SqlConnection(connectionString);
		//data type to reference the sql command you want to do to a specific connection
		SqlCommand command = new SqlCommand(sql, connection);
		command.Parameters.AddWithValue("@ID", ID); 
             
        Tickets ticketinfo = new Tickets(); 
		try 
		{
		   //opening the connection to the database
		   connection.Open();
		   //storing the result set of a DQL statement into a variable
		   SqlDataReader reader = command.ExecuteReader(); //I'll likely need to modify this for drop table
		   while (reader.Read()) 
		   {
		   	  ticketinfo = new Tickets((int)reader[0], (int)reader[1], (int)reader[2], (string)reader[3], (string)reader[4], (double)reader[5]);
		   }

		   reader.Close();
		   connection.Close();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}

         return ticketinfo; 
    }
    public List<Tickets> GetByAuthorID(int ID) {
    	string sql = "select * from ERS.tickets where author_ID = @ID;";

    	SqlConnection connection = new SqlConnection(connectionString);
		//data type to reference the sql command you want to do to a specific connection
		SqlCommand command = new SqlCommand(sql, connection);
		command.Parameters.AddWithValue("@ID", ID); 
             
        List<Tickets> ticketinfo = new List<Tickets>();
		try 
		{
		   //opening the connection to the database
		   connection.Open();
		   //storing the result set of a DQL statement into a variable
		   SqlDataReader reader = command.ExecuteReader(); //I'll likely need to modify this for drop table
		   while (reader.Read()) 
		   {
		   	  ticketinfo.Add(new Tickets((int)reader[0], (int)reader[1], (int)reader[2], (string)reader[3], (string)reader[4], (double)reader[5]));
		   }

		   reader.Close();
		   connection.Close();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}

         return ticketinfo; 
    }
    public List<Tickets> GetByTicketStatus(string status) {
    	string sql = "select * from ERS.tickets where ticketStatus = @ticketStatus;";

    	SqlConnection connection = new SqlConnection(connectionString);
		//data type to reference the sql command you want to do to a specific connection
		SqlCommand command = new SqlCommand(sql, connection);
		command.Parameters.AddWithValue("@ticketStatus", status); 
             
        List<Tickets> ticketinfo = new List<Tickets>();
		try 
		{
		   //opening the connection to the database
		   connection.Open();
		   //storing the result set of a DQL statement into a variable
		   SqlDataReader reader = command.ExecuteReader(); //I'll likely need to modify this for drop table
		   while (reader.Read()) 
		   {
		   	  ticketinfo.Add(new Tickets((int)reader[0], (int)reader[1], (int)reader[2], (string)reader[3], (string)reader[4], (double)reader[5]));
		   }

		   reader.Close();
		   connection.Close();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}

         return ticketinfo; 
    }
}
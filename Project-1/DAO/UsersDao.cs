using System.Data.SqlClient;
using Models;
using System.Collections.Generic;

namespace UDAO;

//The purpose of this layer is to execute the SQL statements to the database

public class UsersDAO 
{
	//the connection string from azure (class level variable)
    string connectionString = "Server=tcp:davidgserver.database.windows.net,1433;Initial Catalog=DavidG;Persist Security Info=False;User ID=sqluser;Password=p4ssw0rd!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";	
	public List<Users> GetAllUsers() {
		List<Users> users = new List<Users>();

        //this defines the sql statement we'd like to execute
        string sql = "select * from ERS.users;"; 

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
		   	  users.Add(new Users((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3]));
		   }
		   reader.Close();
		   connection.Close();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}

           return users;
	}
	public void CreateUser(Users user) {
		//this defines the sql statement we'd like to execute
        string sql = "insert into ERS.users (username, password, userrole) values (@username, @password, @userrole);";

		//data type for an active connection
		SqlConnection connection = new SqlConnection(connectionString);
		//data type to reference the sql command you want to do to a specific connection
		SqlCommand command = new SqlCommand(sql, connection);
		command.Parameters.AddWithValue("@username", user.userName); //AddWithValue assigns variable values
        command.Parameters.AddWithValue("@password", user.password); //could I just reference an older value from the database here?
        command.Parameters.AddWithValue("@userrole", user.role); //AddWithValue assigns variable values
		try 
		{
		   //opening the connection to the database
		   connection.Open();
		   //this is for DML statements
		   int rowsAffected = command.ExecuteNonQuery();
		  
		   if (rowsAffected != 0)
		   {
		   	Console.WriteLine("You registered as: " + user.userName);
		   }
		 
		   connection.Close();

		   
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		
	}

	public Users GetByUsername(string username) {
    	string sql = "select * from ERS.users where username = @name;";

    	SqlConnection connection = new SqlConnection(connectionString);
		//data type to reference the sql command you want to do to a specific connection
		SqlCommand command = new SqlCommand(sql, connection);
		command.Parameters.AddWithValue("@name", username); 
             
        Users userinfo = new Users(); 
		try 
		{
		   //opening the connection to the database
		   connection.Open();
		   //storing the result set of a DQL statement into a variable
		   SqlDataReader reader = command.ExecuteReader(); //I'll likely need to modify this for drop table
		   while (reader.Read()) 
		   {
		   	  userinfo = new Users((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3]);
		   }

		   reader.Close();
		   connection.Close();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}

         return userinfo; 
    }

    public Users GetByID(int ID) {
    	string sql = "select * from ERS.users where userID = @ID;";

    	SqlConnection connection = new SqlConnection(connectionString);
		//data type to reference the sql command you want to do to a specific connection
		SqlCommand command = new SqlCommand(sql, connection);
		command.Parameters.AddWithValue("@ID", ID); 
             
        Users userinfo = new Users(); 
		try 
		{
		   //opening the connection to the database
		   connection.Open();
		   //storing the result set of a DQL statement into a variable
		   SqlDataReader reader = command.ExecuteReader(); //I'll likely need to modify this for drop table
		   while (reader.Read()) 
		   {
		   	  userinfo = new Users((int)reader[0], (string)reader[1], (string)reader[2], (string)reader[3]);
		   }

		   reader.Close();
		   connection.Close();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}

         return userinfo; 
    }
}
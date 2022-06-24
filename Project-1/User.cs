namespace Models;

public class User
{
    //Empty Constructor
    public User()
    {
        UserName = ""; 
        UserID = 0;
        Password = "";
        Role = "";
    }

    //This is constructor overloading
    public User(string name)
    {
        UserName = name;
        UserID = 0;
        Password = "";
        Role = "";
    }

    public User(string name, int ID)
    {
        UserName = name;
        UserID = ID;
        Password = "";
        Role = "";
    }

    public User(string name, int ID, string code)
    {
        UserName = name;
        UserID = ID;
        Password = code;
        Role = "";
    }

    public User(string name, int ID, string code, string employeeRole)
    {
        UserName = name;
        UserID = ID;
        Password = code;
        Role = employeeRole;
    }



    //private fields/methods/etc is only accessible by its owner
    
     public string UserName { get; set; }
     public int UserID { get; set; }
     public string Password { get; set; } 
     public string Role { get; set; }
}
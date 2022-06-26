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
        Console.WriteLine("You entered nothing");
    }

    //This is constructor overloading
    public User(string name)
    {
        UserName = name;
        UserID = 0;
        Password = "";
        Role = "";
        Console.WriteLine("You entered only 1 thing");
    }

    public User(string name, int ID)
    {
        UserName = name;
        UserID = ID;
        Password = "";
        Role = "";
        Console.WriteLine("You entered only 2 things");
    }

    public User(string name, int ID, string code)
    {
        UserName = name;
        UserID = ID;
        Password = code;
        Role = "";
        Console.WriteLine("You entered only 3 things");
    }

    public User(string name, int ID, string code, string employeeRole)
    {
        UserName = name;
        UserID = ID;
        Password = code;
        Role = employeeRole;
        Console.WriteLine("You entered all information");
    }



    //private fields/methods/etc is only accessible by its owner
    
     public string UserName { get; set; }
     public int UserID { get; set; }
     public string Password { get; set; } 
     public string Role { get; set; }
}
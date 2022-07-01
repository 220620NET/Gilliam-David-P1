namespace UI;

public class MainMenu
{
     public void Start()
    {
        do
        {
            Console.WriteLine("Welcome to Expense Reimbursement System");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("[1] Login");
            Console.WriteLine("[2] Register");
            Console.WriteLine("[x] Exit");
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    //log in
                    Console.WriteLine("Username: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Password: ");
                    string password = Console.ReadLine();
                    Console.WriteLine($"You logged in as {name}");
                break;
                case "2":
                    //register
                    Console.WriteLine("Registering a new user");
                    Console.WriteLine("Username: ");
                    string username = Console.ReadLine();
                    Console.WriteLine("You registered your username as: " + username);
                    Console.WriteLine("Role: ");
                    string role = Console.ReadLine();
                    Console.WriteLine("You registered your role as: " + role);

                break;
                case "x":
                    Console.WriteLine("goodbye, see you again soon!");
                    System.Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("Not a valid entry");
                break;
            }

        } while(true);
    }
}
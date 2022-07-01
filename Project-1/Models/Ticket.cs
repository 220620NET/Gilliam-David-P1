namespace Models;

public class Ticket
{
   public Ticket() 
   {
    author = "";
    ticketID = 0;
    resolver = "";
    ticketDescription = "";
    ticketStatus = "";
    ticketAmount = 0.00; 
   }
   
   public string author { get; set; }
   public int ticketID { get; set; }
   public string resolver { get; set; } 
   public string ticketDescription { get; set; }
   public string ticketStatus { get; set; }
   public double ticketAmount { get; set; }
}


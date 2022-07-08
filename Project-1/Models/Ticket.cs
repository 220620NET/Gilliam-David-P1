namespace Models;

public class Ticket
{
   public Ticket() 
   {
    ticketID = 0;
    author = 0;
    resolver = 0;
    ticketDescription = "";
    ticketStatus = "";
    ticketAmount = 0.00; 
   }
   
   public int ticketID { get; set; }
   public int author { get; set; }
   public int resolver { get; set; } 
   public string ticketDescription { get; set; }
   public string ticketStatus { get; set; }
   public double ticketAmount { get; set; }
}

